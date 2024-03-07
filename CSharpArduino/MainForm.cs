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
        static Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();

            // Initialize MainForm settings
            //this.Width = 560;
            //this.Height = 600;
            this.AutoScaleMode = AutoScaleMode.None;

            // Embed the Form into the Container (TabControl, Panel...)
            frmLog.Into(pnLogProgress);
            Serial.Into(pnSerial);

            TimeCounter.startTime = DateTime.Now;
            AddExampleList();
        }

        public int random(int min, int max)
        {
            return rnd.Next(min, max - 1);
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

        #region -- Example Code List Box --
        private void AddExampleList()
        {
            listBox1.Items.Add("Ex0");
            listBox1.Items.Add("Ex1");
            listBox1.Items.Add("Ex2_HW1");
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            RunExample(listBox1.SelectedIndex);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RunExample(listBox1.SelectedIndex);
            }
        }
        #endregion

        #region -- Run Example Code --
        private void RunExample(int ex)
        {
            switch(ex)
            {
                case 0: Ex0(); break;
                case 1: Ex1(); break;
                case 2: Ex2(); break;
            }
        }
        private void Ex0()
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

        private void Ex1()
        {
            long dtStart = TimeCounter.millis();
            long dtEnd = TimeCounter.millis();
            for (int i= 0; i < 5; i++)
            {
                long diff = dtEnd - dtStart;
                while (diff < 200)
                {
                    
                    dtEnd = TimeCounter.millis();
                    diff = dtEnd - dtStart;
                }
                dtStart = TimeCounter.millis();
                Serial.write(TimeCounter.millis().ToString() + "\n");
                Serial.write(diff.ToString() + $" ({i+1})\n");
            }
            Serial.write(TimeCounter.millis().ToString() + "\n");
            Serial.write("(1000 ms)\n");
        }

        int input = 0;
        int answer = 0;
        private void Ex2()
        {
            int min = 0, max = 100;
            answer = random(min, max);
            Serial.write("Answer number = ");
            Serial.write(Serial.read());
            Serial.write("\nEnter two digit number: ");
            Serial.write(Serial.read());
            while (input != answer)
            {
                Serial.write("\nAnswer range: ");
                Serial.write("\nEnter two digit number: ");
                while (input >= 0 && input < 100)
                {
                    //input = Convert.ToInt32(Serial.read());
                    //Serial.write(input.ToString());
                }
                if(input != answer)
                {
                    if(input<=min || input >= max)
                    {
                    }
                }
            }
            Serial.write("\nCorrect, the answer is: ");
            Serial.write(answer.ToString());
        }
        #endregion
    }
}
