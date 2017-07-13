using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clickchecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelClick_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelClick_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panelClick_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panelClick_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Logit("double",e);
        }

        int linecount_;
        private void panelClick_MouseDown(object sender, MouseEventArgs e)
        {
            Logit("single",e);
        }

        private void Logit(string clicktype, MouseEventArgs e)
        {
            linecount_++;
            StringBuilder line = new StringBuilder();
            line.Append(linecount_);
            line.Append(": ");
            line.Append(clicktype);
            line.Append(e.Button.ToString());
            line.AppendLine();
            txtLog.AppendText(line.ToString());
        }
    }
}
