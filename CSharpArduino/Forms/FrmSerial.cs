﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpArduino
{
    public partial class FrmSerial : Form
    {
        public FrmSerial()
        {
            InitializeComponent();
        }

        public void write(string s)
        {
            SerialLog.AppendText(s);
            SerialLog.ScrollToCaret();
        }
    }
}
