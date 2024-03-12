using System;
using System.Windows.Forms;

namespace CSharpArduino
{
    public partial class MainForm : Form
    {
        #region -- GLOBAL VARIABLES --
        static readonly FrmLogBoxProgressBar frmLog = new FrmLogBoxProgressBar();
        static readonly FrmInputMsg frmInMsg = new FrmInputMsg();
        //static readonly FrmSerial Serial = new FrmSerial();
        static FrmSerial Serial = null;
        static FrmVersionLog frmVer = null;

        static Random rnd = new Random();
        private DateTime startTime;
        private string[] exampleList = { "Ex0", "Ex1", "Ex2_HW1" };
        #endregion

        public MainForm()
        {
            InitializeComponent();

            // Initialize MainForm settings
            this.Width = 560;
            this.Height = 600;
            this.AutoScaleMode = AutoScaleMode.None;

            // Embed the Form into the Container (TabControl, Panel...)
            //Serial.Into(pnSerial);
            frmLog.Into(pnLogProgress);
            frmInMsg.Into(pnInMsg);

            startTime = DateTime.Now;
            AddExampleList();
        }

        #region -- Common Functions --
        public long millis()
        {
            DateTime endTime = DateTime.Now;
            double diff = (endTime - startTime).TotalMilliseconds;
            return Convert.ToUInt32(diff);
        }

        public long micros()
        {
            DateTime endTime = DateTime.Now;
            double diff = (endTime - startTime).TotalMilliseconds;
            return Convert.ToUInt32(diff);
        }

        public int random(int min, int max)
        {
            return rnd.Next(min, max - 1);
        }
        #endregion

        #region -- Strip Menu, Tab Control Items --
        private void serialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Serial == null)
            {
                Serial = new FrmSerial();
                Serial.Show();
                Serial.Disposed += new EventHandler(FrmSerial_Disposed);
            }
            else
            {
                Serial.WindowState = FormWindowState.Normal;
                Serial.BringToFront();
            }
        }

        void FrmSerial_Disposed(object sender, EventArgs e)
        {
            Serial = null;
        }

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
            foreach (string ex in exampleList)
            {
                listBox1.Items.Add(ex);
            }
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
            long dtStart = millis();
            long dtEnd = millis();
            for (int i= 0; i < 5; i++)
            {
                long diff = dtEnd - dtStart;
                while (diff < 200)
                {
                    
                    dtEnd = millis();
                    diff = dtEnd - dtStart;
                }
                dtStart = millis();
                Serial.write(millis().ToString() + "\n");
                Serial.write(diff.ToString() + $" ({i+1})\n");
            }
            Serial.write(millis().ToString() + "\n");
            Serial.write("(1000 ms)\n");
        }

        private void Ex2()
        {
            int input = 0, answer = 0;
            int min = 0, max = 100;
            answer = random(min, max);
            Serial.print("\nAnswer number = ");
            Serial.print(answer, "DEC");
            Serial.print("\nEnter two digit number: ");
            Serial.print(Serial.read());
            while (input != answer)
            {
                Serial.print($"\nRange of answer:");
                Serial.print("\n");
                Serial.print(min, "DEC");
                Serial.print("\n");
                Serial.print(max, "DEC");
                Serial.print("\nEnter two digit number: ");
                while (!Serial.available())
                {
                    Serial.ReadLine();
                    if (Serial.available())
                    {
                        string s = Serial.read();
                        input = Convert.ToInt32(s);
                        Serial.print(input.ToString());
                        break;
                    }
                }
                if (input != answer)
                {
                    Serial.print("\nWrong answer! ");
                    if (input > min && input < answer)
                    {
                        min = input;
                    }
                    else if (input < max && input > answer)
                    {
                        max = input;
                    };
                }
            }
            Serial.print("\nCorrect, the answer is: ");
            Serial.print(answer.ToString());
        }
        #endregion
    }
}
