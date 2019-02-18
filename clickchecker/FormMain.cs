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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void panelClick_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(chkShowDoubleClick.Checked)
                Logit("Double",e,"");
        }

        int linecount_;
        private void panelClick_MouseDown(object sender, MouseEventArgs e)
        {
            if(chkShowSingleClick.Checked)
                if(chkShowDown.Checked)
                    Logit("Single",e,"down");
        }
        private void panelClick_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkShowSingleClick.Checked)
                if (chkShowUp.Checked)
                    Logit("Single", e,"up");
        }

        private void Logit(string clicktype, MouseEventArgs e, string upordown)
        {
            linecount_++;
            StringBuilder line = new StringBuilder();
            line.Append(linecount_);
            line.Append(": ");
            line.Append(clicktype);
            line.Append(" ");
            line.Append(e.Button.ToString());
            
            line.Append(" count=");
            line.Append(e.Clicks);

            line.Append(" ");
            line.Append(upordown);

            line.AppendLine();
            txtLog.AppendText(line.ToString());
        }

    }
}
