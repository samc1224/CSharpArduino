using System;
using System.Windows.Forms;

namespace CSharpArduino
{
    public partial class FrmSerial : Form
    {
        private string strInput = "";
        public FrmSerial()
        {
            InitializeComponent();
        }

        public void print(int n, string s)
        {
            string str = Convert.ToString(n);
            SerialLog.AppendText(str);
            SerialLog.ScrollToCaret();
        }

        public void print(string s)
        {
            SerialLog.AppendText(s);
            SerialLog.ScrollToCaret();
        }

        public void println(string s)
        {
            SerialLog.AppendText(s);
            SerialLog.AppendText("\n");
            SerialLog.ScrollToCaret();
        }

        public void write(string s)
        {
            SerialLog.AppendText(s);
            SerialLog.ScrollToCaret();
        }

        public string read()
        {
            string str = strInput;
            strInput = "";
            return str;
        }

        public string ReadLine()
        {
            string str = strInput;
            // Message window style
            FrmInputMsg frmMsg = new FrmInputMsg();
            DialogResult dr = frmMsg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                str = frmMsg.ReturnMsg();
                SerialInput.Text = str;
                strInput = str;
            }

            //strInput = "";
            return str;
        }

        public bool available()
        {
            if (strInput == "")
            {
                return false;
            }
            return true;
        }

        private void SendSerialInputBtn_Click(object sender, EventArgs e)
        {
            strInput = SerialInput.Text;
        }

        private void ClearSerialLogBtn_Click(object sender, EventArgs e)
        {
            SerialLog.Text = "";
        }

        private void CallConsoleWindowBtn_Click(object sender, EventArgs e)
        {
            // Example 1: Display ipconfig messages
            string cmd = @SerialInput.Text;
            //string cmd = @"ipconfig/all";
            //string cmd = @"ping 127.0.0.1";

            // Example 2: Open the VS2010 command prompt
            //string cmd = @"C:&cd C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC&vcvarsall.bat";

            // Example 3: Use the sn.exe tool to generate a key pair and display it
            //string cmd = @"C:&cd C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC&vcvarsall.bat&sn -k d:\LicBase.snk&sn -p d:\LicBase.snk d:\LicBasePubKey.snk&sn -tp d:\LicBasePubKey.snk";
            
            string output = "";
            if (cmd != "" && cmd != null)
            {
                CmdHelper.RunCmd(cmd, out output);
                print(output);
            }
            //CmdHelper.OpenCmdWindow(cmd);
        }
    }
}
