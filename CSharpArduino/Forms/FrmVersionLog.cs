using System;
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
    public partial class FrmVersionLog : Form
    {
        public FrmVersionLog()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmVersionLog_Load(object sender, EventArgs e)
        {
            VersionLogTb.Select(0, 8);
        }

        private void OKtoCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
