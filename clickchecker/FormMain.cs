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
using System.Diagnostics;
using System.Reflection;

namespace clickchecker
{
    public partial class FormMain : Form
    {
        readonly string SECTION_OPTION = "Option";
        readonly string KEY_CHECK_SINGLECLICK = "CheckSingleClick";
        readonly string KEY_CHECK_DOUBLECLICK = "CheckDoubleClick";
        readonly string KEY_CHECK_UP = "CheckUp";
        readonly string KEY_CHECK_DOWN = "CheckDown";
        readonly string KEY_CHECK_WHEEL = "CheckWheel";
        readonly string KEY_CHECK_MOVE = "CheckMove";
        readonly string KEY_SPLITTER_DISTANCE = "SplitterDistance";

        readonly string SECTION_LOCATION = "Window";
        readonly HashIni ini_;

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

            this.panelClick.MouseWheel += panelClick_MouseWheel;
            // Load from ini file
            bool bval;
            try
            {
                ini_ = Profile.ReadAll(IniPath, true);

                Profile.GetBool(SECTION_OPTION, KEY_CHECK_SINGLECLICK, true, out bval, ini_);
                chkShowSingleClick.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_DOUBLECLICK, false, out bval, ini_);
                chkShowDoubleClick.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_UP, false, out bval, ini_);
                chkShowUp.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_DOWN, true, out bval, ini_);
                chkShowDown.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_WHEEL, true, out bval, ini_);
                chkShowWheel.Checked = bval;
                Profile.GetBool(SECTION_OPTION, KEY_CHECK_MOVE, true, out bval, ini_);
                chkShowMove.Checked = bval;

                AmbLib.LoadFormXYWH(this, SECTION_LOCATION, ini_);
            }
            catch(FileNotFoundException)
            { 
            }
            catch (Exception ex)
            {
                CppUtils.Alert(ex);
                Environment.Exit(1);
            }

            // Set Title
            this.Text = Application.ProductName;
        }

        void panelClick_MouseWheel(object sender, MouseEventArgs e)
        {
            if(chkShowWheel.Checked)
                Logit("Wheel", e, e.Delta.ToString());
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

        private void panelClick_MouseMove(object sender, MouseEventArgs e)
        {
            if (chkShowMove.Checked)
                Logit("Move", e, string.Format("X={0},Y={1}", e.X, e.Y));
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

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool success = true;

            HashIni ini = Profile.ReadAll(IniPath);

            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_SINGLECLICK, chkShowSingleClick.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_DOUBLECLICK, chkShowDoubleClick.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_UP, chkShowUp.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_DOWN, chkShowDown.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_WHEEL, chkShowWheel.Checked, ini);
            success &= Profile.WriteBool(SECTION_OPTION, KEY_CHECK_MOVE, chkShowMove.Checked, ini);

            success &= AmbLib.SaveFormXYWH(this, SECTION_LOCATION, ini);

            success &= Profile.WriteInt(SECTION_OPTION, KEY_SPLITTER_DISTANCE, splitMain.SplitterDistance, ini);

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

            if (!success)
            {
                CppUtils.Alert(Properties.Resources.SAVE_FAILED);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int ival;
            if (ini_ != null)
            {
                Profile.GetInt(SECTION_OPTION, KEY_SPLITTER_DISTANCE, -1, out ival, ini_);
                if (ival != -1)
                    splitMain.SplitterDistance = ival;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var message = new StringBuilder();
            message.AppendLine(string.Format("{0} v{1}",
                Application.ProductName,
                AmbLib.getAssemblyVersion(Assembly.GetExecutingAssembly(), 3)));
            message.AppendLine();
            message.AppendLine("https://ambiesoft.github.io/webjumper/?target=clickchecker");

            JR.Utils.GUI.Forms.FlexibleMessageBox.Show(this,
                message.ToString(),
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                
        }

    }
}
