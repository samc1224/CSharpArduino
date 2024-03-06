using System;
using System.Windows.Forms;

namespace CSharpArduino
{
    static class FormEmbedded
    {
        /// <summary>
        /// Embed the Form into the Container (TabControl, Panel, ...)
        /// </summary>
        /// <param name="form">The Form to be embedded</param>
        /// <param name="control">Container for Form embedding</param>
        public static void Into(this Form form, Control control)
        {
            if (form == null || form.InvokeRequired)
            {
                form?.Invoke((Action)(() => Into(form, control))); // Avoid cross-thread exceptions
                return;
            }
            form.TopLevel = false;
            form.Parent = control;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = System.Drawing.Color.White;
            form.Show();
        }
    }
}
