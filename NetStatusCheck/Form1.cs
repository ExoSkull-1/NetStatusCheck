using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;

namespace NetStatusCheck
{
    public partial class frmMain : Form
    {
        private Ping _pinger = new Ping();
        private IPStatus _status;
        private bool _isFirst = true;
        private int _pingCounter = 0;
        private int _maxPingCounter = 3;
        private bool _isRunning = false;
        private bool _cancel = false;

        private BackgroundWorker _pingWorker = new BackgroundWorker();

        public frmMain()
        {
            InitializeComponent();
            _pingWorker.WorkerSupportsCancellation = true;
            _pingWorker.DoWork += _pingWorker_DoWork;
        }

        private async void _pingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _isFirst = true;

            while (!_cancel)
            {
                try
                {
                    await CheckForConnection();
                    VisualizePing();
                }
                catch(Exception ex)
                {
                    AddStatusString("Internal Error occured at around " + DateTime.Now + ". Reading: " + Environment.NewLine + ex.Message);
                }

                var nextPing = DateTime.Now.AddSeconds((double)numInterval.Value);
                while(DateTime.Now < nextPing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }

            ResetPingVisualization();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _cancel = _isRunning;

            if (_isRunning)
            {
                AddStatusString("Stopped watching at " + DateTime.Now);
                btnStart.Text = "Start watching";
            }
            else
            {
                _pingWorker.RunWorkerAsync();
                AddStatusString("Began watching at " + DateTime.Now);
                btnStart.Text = "Stop watching";
            }

            _isRunning = !_isRunning;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "";
        }

        private async Task CheckForConnection()
        {
            try
            {
                PingReply reply = await _pinger.SendPingAsync(txtIP.Text, (int)numMaxTimeout.Value * 1000);

                if (_isFirst)
                {
                    AddStatusString("Initial status: " + reply.Status);
                    _isFirst = false;
                }

                if (reply.Status != _status)
                {
                    AddStatusString($"Netstatus changed to [{reply.Status}] at approximately {DateTime.Now}.");
                }
                _status = reply.Status;
            }
            catch (PingException ex)
            {
                AddStatusString("Internal Error occured at around " + DateTime.Now + ". Reading: " + Environment.NewLine + ex.Message);
            }
        }

        private void VisualizePing()
        {
            string pingText;
            _pingCounter = (_pingCounter + 1) % (_maxPingCounter + 1);

            pingText = "[";
            for(int i = 0; i < _maxPingCounter; i++)
            {
                pingText += i < _pingCounter ? "." : " ";
            }
            pingText += "]";

            Invoke((Action)(() =>
            {
                lblPing.Text = pingText;
                imgStatus.BackColor = _status == IPStatus.Success ? Color.LightGreen : Color.DarkRed;
            }));
        }

        private void ResetPingVisualization()
        {
            Invoke((Action)(() =>
            {
                lblPing.Text = "[   ]";
                imgStatus.BackColor = Color.White;
            }));
        }

        private void AddStatusString(string statusText)
        {
            Invoke((Action)(() =>
            {
                StatusBox.Text += statusText + Environment.NewLine;
            }));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cancel = true;
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, StatusBox.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while saving", MessageBoxButtons.OK);
            }
        }
    }
}
