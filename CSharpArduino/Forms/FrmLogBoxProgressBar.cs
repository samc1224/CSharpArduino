using System.Text;
using System.Threading;
using System.Windows.Forms;
using System;

namespace CSharpArduino
{
    public partial class FrmLogBoxProgressBar : Form
    {
        private SynchronizationContext UISync;

        public FrmLogBoxProgressBar()
        {
            InitializeComponent();

            // Initialize UI Sync Method
            this.UISync = SynchronizationContext.Current;
        }

        public void TaskProgressBar(int percentage)
        {
            if (percentage < 0)
                percentage = 0;
            if (percentage > 100)
                percentage = 100;

            UISync.Send((doing) =>
            {
                progressBar1.Value = percentage;
                progressMsg.Text = percentage.ToString() + " %";
            }, null);
        }

        public void TaskAppendNewLineTextIntoLog(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            sb.Append(Environment.NewLine);

            UISync.Send((doing) =>
            {
                LogRTBox.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + sb.ToString());
                LogRTBox.ScrollToCaret();
            }, null);
        }

        public void TaskAppendTextOnlyLog(string text)
        {
            UISync.Send((doing) =>
            {
                LogRTBox.AppendText(text);
                LogRTBox.ScrollToCaret();
            }, null);
        }

        public bool IsShowAllLogs()
        {
            if (ShowAllLogsCb.Checked == true)
                return true;
            else
                return false;
        }

        private void ShowAllLogsCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowAllLogsCb.Checked == true)
                LogRTBox.ReadOnly = true;
            else
                LogRTBox.ReadOnly = false;
        }
    }
}
