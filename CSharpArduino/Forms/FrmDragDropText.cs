using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CSharpArduino
{
    public partial class FrmDragDropText : Form
    {
        private Timer timer1 = new Timer();
        private Label label = new Label();
        public string text = "Test the text scroll effect";

        public FrmDragDropText()
        {
            InitializeComponent();

            // Allow textbox to be dragged and dropped
            txtContent.AllowDrop = true;

            // Test the text scroll effect
            this.label.Location = new Point(149, 13);
            this.label.Size = new Size(134, 16);
            this.Controls.Add(label);
            this.label.Text = "";
            this.timer1.Enabled = true;
            this.timer1.Interval = 100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            p = new PointF(this.label.Size.Width, 0);
        }

        private void FrmDragDropText_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Enabled = false;
        }

        #region -- Test text scrolling effect --
        PointF p;
        Font f = new Font("Microsoft Sans Serif", 10);
        Color c = Color.White;
        string temp;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Graphics g = this.label.CreateGraphics();
            SizeF s = new SizeF();
            s = g.MeasureString(text, f); // Measure text length
            Brush brush = Brushes.Black;
            g.Clear(c); // Clear background

            if (temp != text) // When the text changes, redisplay it
            {
                p = new PointF(this.label.Size.Width, 0);
                temp = text;
            }
            else
            {
                p = new PointF(p.X - 10, 0); // Offset by 10 each time
            }
            if (p.X <= -s.Width)
            {
                p = new PointF(this.label.Size.Width, 0);
            }
            g.DrawString(text, f, brush, p);
        }

        private void TextScrollRun_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void TextScrollStop_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }
        #endregion

        #region -- Test dragging a text file and displaying it --
        private void txtContent_DragEnter(object sender, DragEventArgs e)
        {

            // Judgement
            // 1. Whether there is a dragged object
            // 2. Whether the object does not have a txt file
            // 3. Is it DataFormats.FileDrop?
            bool fileformatCheck = e.Data.GetDataPresent(DataFormats.FileDrop);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if
            (
            fileformatCheck == false || files == null || files.Length == 0
            //|| Path.GetExtension(files[0]).ToUpperInvariant() != ".TXT"
            )
            {
                // 當 e.Effect = DragDropEffects.None 時，DragDrop 事件不會被觸發
                e.Effect = DragDropEffects.None;
            }
            else
            {
                // 當 e.Effect = DragDropEffects.Copy （非DragDropEffects.None）時，DrapDrop 事件會被觸發，且 TextBox 上的拖曳符號會變成 +
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void txtContent_DragDrop(object sender, DragEventArgs e)
        {

            // 已經在 DrapEnter 內進行防呆，DrapDrop 內就直接抓取資料
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string filepath = files[0];
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            // Encoding.Default 可以避免內容產生亂碼
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            txtContent.Text = sr.ReadToEnd();
        }
        #endregion
    }
}
