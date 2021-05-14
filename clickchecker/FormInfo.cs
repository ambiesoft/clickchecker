using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace clickchecker
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();

            lblVersion.Text = string.Format("{0} version {1}",
                Application.ProductName,
                Ambiesoft.AmbLib.getAssemblyVersion(Assembly.GetExecutingAssembly(), 3));
        }

        void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                Ambiesoft.CppUtils.Alert(ex);
            }
        }
        private void linkWebPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://ambiesoft.github.io/webjumper/?target=clickchecker");
        }

        private void linkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://ambiesoft.github.io/webjumper/?target=donate");
        }
    }
}
