namespace CSharpArduino
{
    partial class FrmDragDropText
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.TextScrollRun = new System.Windows.Forms.Button();
            this.TextScrollStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(2, 45);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(373, 289);
            this.txtContent.TabIndex = 0;
            this.txtContent.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtContent_DragDrop);
            this.txtContent.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtContent_DragEnter);
            // 
            // TextScrollRun
            // 
            this.TextScrollRun.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextScrollRun.Location = new System.Drawing.Point(12, 9);
            this.TextScrollRun.Name = "TextScrollRun";
            this.TextScrollRun.Size = new System.Drawing.Size(55, 25);
            this.TextScrollRun.TabIndex = 215;
            this.TextScrollRun.Text = "Run";
            this.TextScrollRun.UseVisualStyleBackColor = true;
            this.TextScrollRun.Click += new System.EventHandler(this.TextScrollRun_Click);
            // 
            // TextScrollStop
            // 
            this.TextScrollStop.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextScrollStop.Location = new System.Drawing.Point(81, 9);
            this.TextScrollStop.Name = "TextScrollStop";
            this.TextScrollStop.Size = new System.Drawing.Size(55, 25);
            this.TextScrollStop.TabIndex = 216;
            this.TextScrollStop.Text = "Stop";
            this.TextScrollStop.UseVisualStyleBackColor = true;
            this.TextScrollStop.Click += new System.EventHandler(this.TextScrollStop_Click);
            // 
            // FrmDragDropText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 338);
            this.Controls.Add(this.TextScrollStop);
            this.Controls.Add(this.TextScrollRun);
            this.Controls.Add(this.txtContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDragDropText";
            this.Text = "DragDropText";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDragDropText_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button TextScrollRun;
        private System.Windows.Forms.Button TextScrollStop;
    }
}