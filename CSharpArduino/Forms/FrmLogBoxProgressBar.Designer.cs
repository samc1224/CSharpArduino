namespace CSharpArduino
{
    partial class FrmLogBoxProgressBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressMsg = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ShowAllLogsCb = new System.Windows.Forms.CheckBox();
            this.LogRTBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // progressMsg
            // 
            this.progressMsg.AutoSize = true;
            this.progressMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressMsg.Location = new System.Drawing.Point(497, 159);
            this.progressMsg.Name = "progressMsg";
            this.progressMsg.Size = new System.Drawing.Size(28, 15);
            this.progressMsg.TabIndex = 199;
            this.progressMsg.Text = "0 %";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(124, 160);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 15);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 198;
            // 
            // ShowAllLogsCb
            // 
            this.ShowAllLogsCb.AutoSize = true;
            this.ShowAllLogsCb.Checked = true;
            this.ShowAllLogsCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAllLogsCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllLogsCb.Location = new System.Drawing.Point(4, 159);
            this.ShowAllLogsCb.Name = "ShowAllLogsCb";
            this.ShowAllLogsCb.Size = new System.Drawing.Size(99, 19);
            this.ShowAllLogsCb.TabIndex = 197;
            this.ShowAllLogsCb.Text = "Show all logs";
            this.ShowAllLogsCb.UseVisualStyleBackColor = true;
            this.ShowAllLogsCb.CheckedChanged += new System.EventHandler(this.ShowAllLogsCb_CheckedChanged);
            // 
            // LogRTBox
            // 
            this.LogRTBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogRTBox.Location = new System.Drawing.Point(3, 2);
            this.LogRTBox.Name = "LogRTBox";
            this.LogRTBox.ReadOnly = true;
            this.LogRTBox.Size = new System.Drawing.Size(532, 150);
            this.LogRTBox.TabIndex = 196;
            this.LogRTBox.Text = "";
            // 
            // FrmLogBoxProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 181);
            this.Controls.Add(this.progressMsg);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ShowAllLogsCb);
            this.Controls.Add(this.LogRTBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogBoxProgressBar";
            this.Text = "frmLogBoxProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progressMsg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox ShowAllLogsCb;
        private System.Windows.Forms.RichTextBox LogRTBox;
    }
}