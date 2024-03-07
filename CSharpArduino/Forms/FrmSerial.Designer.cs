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
            this.StopSerialPortCb = new System.Windows.Forms.CheckBox();
            this.ClearSerialPortBtn = new System.Windows.Forms.Button();
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
            // StopSerialPortCb
            // 
            this.StopSerialPortCb.AutoSize = true;
            this.StopSerialPortCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopSerialPortCb.Location = new System.Drawing.Point(271, 486);
            this.StopSerialPortCb.Name = "StopSerialPortCb";
            this.StopSerialPortCb.Size = new System.Drawing.Size(108, 19);
            this.StopSerialPortCb.TabIndex = 198;
            this.StopSerialPortCb.Text = "Stop serial port";
            this.StopSerialPortCb.UseVisualStyleBackColor = true;
            // 
            // ClearSerialPortBtn
            // 
            this.ClearSerialPortBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSerialPortBtn.Location = new System.Drawing.Point(3, 482);
            this.ClearSerialPortBtn.Name = "ClearSerialPortBtn";
            this.ClearSerialPortBtn.Size = new System.Drawing.Size(66, 25);
            this.ClearSerialPortBtn.TabIndex = 211;
            this.ClearSerialPortBtn.Text = "Clear";
            this.ClearSerialPortBtn.UseVisualStyleBackColor = true;
            // 
            // FrmSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 509);
            this.Controls.Add(this.ClearSerialPortBtn);
            this.Controls.Add(this.StopSerialPortCb);
            this.Controls.Add(this.SerialLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSerial";
            this.Text = "Serial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SerialLog;
        private System.Windows.Forms.CheckBox StopSerialPortCb;
        private System.Windows.Forms.Button ClearSerialPortBtn;
    }
}