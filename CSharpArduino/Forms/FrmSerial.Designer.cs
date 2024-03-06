namespace CSharpArduino
{
    partial class FrmSerial
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
            this.SerialLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SerialLog
            // 
            this.SerialLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialLog.Location = new System.Drawing.Point(0, 0);
            this.SerialLog.Name = "SerialLog";
            this.SerialLog.ReadOnly = true;
            this.SerialLog.Size = new System.Drawing.Size(390, 480);
            this.SerialLog.TabIndex = 197;
            this.SerialLog.Text = "";
            // 
            // Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 480);
            this.Controls.Add(this.SerialLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Serial";
            this.Text = "Serial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SerialLog;
    }
}