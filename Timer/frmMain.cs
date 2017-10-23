using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class frmMain : Form
    {
        int maxTime = 0;
        int currentTime = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            currentTime++;
            pgbTimeRemaining.Value = currentTime;
            updTime.Value = currentTime;
            if (currentTime >= maxTime)
            {
                StopTimer();
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            currentTime = 0;
            maxTime = (int) updTime.Value;
            pgbTimeRemaining.Maximum = maxTime;
            updTime.Enabled = false;
            btnBegin.Enabled = false;
            btnStop.Enabled = true;
            tmrMain.Start();
        }

        private void StopTimer()
        {
            tmrMain.Stop();
            updTime.Enabled = true;
            updTime.Value = maxTime;
            btnBegin.Enabled = true;
            btnStop.Enabled = false;
            MessageBox.Show("Timer Finished!");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
    }
}
