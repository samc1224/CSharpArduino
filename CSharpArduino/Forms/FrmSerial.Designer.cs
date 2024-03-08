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
            this.ClearSerialLogBtn = new System.Windows.Forms.Button();
            this.SerialInput = new System.Windows.Forms.TextBox();
            this.SendSerialInputBtn = new System.Windows.Forms.Button();
            this.CallConsoleWindowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerialLog
            // 
            this.SerialLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialLog.Location = new System.Drawing.Point(2, 30);
            this.SerialLog.Name = "SerialLog";
            this.SerialLog.ReadOnly = true;
            this.SerialLog.Size = new System.Drawing.Size(390, 455);
            this.SerialLog.TabIndex = 197;
            this.SerialLog.Text = "";
            // 
            // StopSerialPortCb
            // 
            this.StopSerialPortCb.AutoSize = true;
            this.StopSerialPortCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopSerialPortCb.Location = new System.Drawing.Point(12, 493);
            this.StopSerialPortCb.Name = "StopSerialPortCb";
            this.StopSerialPortCb.Size = new System.Drawing.Size(108, 19);
            this.StopSerialPortCb.TabIndex = 198;
            this.StopSerialPortCb.Text = "Stop serial port";
            this.StopSerialPortCb.UseVisualStyleBackColor = true;
            // 
            // ClearSerialLogBtn
            // 
            this.ClearSerialLogBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSerialLogBtn.Location = new System.Drawing.Point(315, 490);
            this.ClearSerialLogBtn.Name = "ClearSerialLogBtn";
            this.ClearSerialLogBtn.Size = new System.Drawing.Size(66, 25);
            this.ClearSerialLogBtn.TabIndex = 211;
            this.ClearSerialLogBtn.Text = "Clear";
            this.ClearSerialLogBtn.UseVisualStyleBackColor = true;
            this.ClearSerialLogBtn.Click += new System.EventHandler(this.ClearSerialLogBtn_Click);
            // 
            // SerialInput
            // 
            this.SerialInput.Location = new System.Drawing.Point(4, 5);
            this.SerialInput.Name = "SerialInput";
            this.SerialInput.Size = new System.Drawing.Size(305, 22);
            this.SerialInput.TabIndex = 212;
            // 
            // SendSerialInputBtn
            // 
            this.SendSerialInputBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendSerialInputBtn.Location = new System.Drawing.Point(315, 4);
            this.SendSerialInputBtn.Name = "SendSerialInputBtn";
            this.SendSerialInputBtn.Size = new System.Drawing.Size(66, 25);
            this.SendSerialInputBtn.TabIndex = 213;
            this.SendSerialInputBtn.Text = "Send";
            this.SendSerialInputBtn.UseVisualStyleBackColor = true;
            this.SendSerialInputBtn.Click += new System.EventHandler(this.SendSerialInputBtn_Click);
            // 
            // CallConsoleWindowBtn
            // 
            this.CallConsoleWindowBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallConsoleWindowBtn.Location = new System.Drawing.Point(231, 490);
            this.CallConsoleWindowBtn.Name = "CallConsoleWindowBtn";
            this.CallConsoleWindowBtn.Size = new System.Drawing.Size(66, 25);
            this.CallConsoleWindowBtn.TabIndex = 214;
            this.CallConsoleWindowBtn.Text = "Console";
            this.CallConsoleWindowBtn.UseVisualStyleBackColor = true;
            this.CallConsoleWindowBtn.Click += new System.EventHandler(this.CallConsoleWindowBtn_Click);
            // 
            // FrmSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 521);
            this.Controls.Add(this.CallConsoleWindowBtn);
            this.Controls.Add(this.SendSerialInputBtn);
            this.Controls.Add(this.SerialInput);
            this.Controls.Add(this.ClearSerialLogBtn);
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
        private System.Windows.Forms.Button ClearSerialLogBtn;
        private System.Windows.Forms.TextBox SerialInput;
        private System.Windows.Forms.Button SendSerialInputBtn;
        private System.Windows.Forms.Button CallConsoleWindowBtn;
    }
}