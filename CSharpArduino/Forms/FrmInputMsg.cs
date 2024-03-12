using System;
using System.Windows.Forms;

namespace CSharpArduino
{
    public partial class FrmInputMsg : Form
    {
        private string msg = "";

        public FrmInputMsg()
        {
            InitializeComponent();

            this.SendBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            msg = InputBox.Text;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            InputBox.Text = "";
        }

        public string ReturnMsg()
        {
            return msg;
        }
    }
}
