using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpArduino
{
    public partial class MainForm : Form
    {
        static readonly FrmLogBoxProgressBar frmLog = new FrmLogBoxProgressBar();
        static readonly FrmSerial Serial = new FrmSerial();
        static FrmVersionLog frmVer = null;

        public MainForm()
        {
            InitializeComponent();

            // Initialize mainForm settings
            this.Width = 560;
            this.Height = 600;
            this.AutoScaleMode = AutoScaleMode.None;

            // Embed the Form into the Container (TabControl, Panel...)
            frmLog.Into(pnLogProgress);
            Serial.Into(pnSerial);

            AddListBox1();
        }

        #region -- Strip Menu, Tab Control Items --
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVer == null)
            {
                frmVer = new FrmVersionLog();
                frmVer.Show();

                // Create an event where the Form is closed (dispose)
                frmVer.Disposed += new EventHandler(FrmLogBox_Disposed);
            }
            else
            {
                // Set form to default size
                frmVer.WindowState = FormWindowState.Normal;
                // Bring the Form to the front of the stacking order (let the reduced Form pop out)
                frmVer.BringToFront();
            }
        }

        // Event that will be triggered when closing the Form
        void FrmLogBox_Disposed(object sender, EventArgs e)
        {
            frmVer = null;
        }
        #endregion

        #region -- List Box (Code List) --
        private void AddListBox1()
        {
            listBox1.Items.Add("Ex0");
            listBox1.Items.Add("Ex1");
            listBox1.Items.Add("Ex2");
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ExampleCode(listBox1.SelectedIndex);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExampleCode(listBox1.SelectedIndex);
            }
        }
        #endregion

        #region -- Example Code --
        private void ExampleCode(int ex)
        {
            switch(ex)
            {
                case 0: Ex0Code(); break;
                case 1: Ex1Code(); break;
                case 2: Ex2Code(); break;
            }
        }
        private void Ex0Code()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    Serial.write(" ");
                }
                for (int j = 0; j < i*2-1; j++)
                {
                    Serial.write("*");
                }
                Serial.write("\n");
            }
        }

        private string millis(double ms)
        {
            return ms.ToString();
        }

        private void Ex1Code()
        {
            DateTime dtStart = DateTime.Now;
            //Thread.Sleep(1000);
            //DateTime dtEnd = DateTime.Now;
            //Serial.write((dtEnd - dtStart).ToString() + "\n");

            DateTime dtEnd = DateTime.Now;
            double diff = 0;
            for (int i= 0; i < 5; i++)
            {
                diff = (dtEnd - dtStart).TotalMilliseconds;
                while (diff < 200)
                {
                    
                    dtEnd = DateTime.Now;
                    diff = (dtEnd - dtStart).TotalMilliseconds;
                }
                dtStart = DateTime.Now;
                Serial.write(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "\n");
                Serial.write(diff.ToString() + $" ({i+1})\n");
            }
            Serial.write(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff") + "\n");
            Serial.write("(1000 ms)\n");
        }

        private void Ex2Code()
        {
            Serial.write("**\n");
        }
        #endregion
    }
}
