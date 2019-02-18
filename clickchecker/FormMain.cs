using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Ambiesoft;

namespace clickchecker
{
    public partial class FormMain : Form
    {
        readonly string SECTION_OPTION = "Option";
        readonly string KEY_CHECK_SINGLECLICK = "CheckSingleClick";
        readonly string KEY_CHECK_DOUBLECLICK = "CheckDoubleClick";
        readonly string KEY_CHECK_UP = "CheckUp";
        readonly string KEY_CHECK_DOWN = "CheckDown";

        readonly string SECTION_LOCATION = "Window";

        string IniPath
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                    Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".ini");
            }
        }
        public FormMain()
        {
            InitializeComponent();

            // Load from ini file
            bool bval;
            try
            {
                HashIni ini = Profile.ReadAll(IniPath, true);

                Profile.GetBool(SECTION_OPTION, KEY_CHECK_SINGLECLICK, true, out bval, ini);
                chkShowSingleClick.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_DOUBLECLICK, false, out bval, ini);
                chkShowDoubleClick.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_UP, false, out bval, ini);
                chkShowUp.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_DOWN, true, out bval, ini);
                chkShowDown.Checked = bval;

                AmbLib.LoadFormXYWH(this, SECTION_LOCATION, ini);
            }
            catch(FileNotFoundException)
            { }
            catch (Exception ex)
            {
                CppUtils.Alert(ex);
                Environment.Exit(1);
            }

            // Set Title
            StringBuilder sbTitle = new StringBuilder();
            sbTitle.Append(Application.ProductName);
            sbTitle.Append(" ");
            sbTitle.Append("ver");
            sbTitle.Append(AmbLib.getAssemblyVersion(System.Reflection.Assembly.GetExecutingAssembly(), 3));
            this.Text = sbTitle.ToString();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool success = true;
          
            HashIni ini = Profile.ReadAll(IniPath);
                
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_SINGLECLICK, chkShowSingleClick.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_DOUBLECLICK, chkShowDoubleClick.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_UP, chkShowUp.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_DOWN, chkShowDown.Checked, ini);

            success &= AmbLib.SaveFormXYWH(this, SECTION_LOCATION, ini);

            if (success)
            {
                try
                {
                    success &= Profile.WriteAll(ini, IniPath, true);
                }
                catch (Exception)
                {
                    success = false;
                }
            }

            if(!success)
            {
                CppUtils.Alert(Properties.Resources.SAVE_FAILED);
            }
        }


    }
}
