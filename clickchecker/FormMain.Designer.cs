namespace clickchecker
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblClickHere = new System.Windows.Forms.Label();
            this.panelClick = new System.Windows.Forms.Panel();
            this.tableBottom = new System.Windows.Forms.TableLayoutPanel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkShowDoubleClick = new System.Windows.Forms.CheckBox();
            this.chkShowSingleClick = new System.Windows.Forms.CheckBox();
            this.chkShowDown = new System.Windows.Forms.CheckBox();
            this.chkShowUp = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkShowWheel = new System.Windows.Forms.CheckBox();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.tableBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            resources.ApplyResources(this.splitMain, "splitMain");
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tableTop);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tableBottom);
            // 
            // tableTop
            // 
            resources.ApplyResources(this.tableTop, "tableTop");
            this.tableTop.Controls.Add(this.lblClickHere, 0, 0);
            this.tableTop.Controls.Add(this.panelClick, 0, 1);
            this.tableTop.Name = "tableTop";
            // 
            // lblClickHere
            // 
            resources.ApplyResources(this.lblClickHere, "lblClickHere");
            this.lblClickHere.Name = "lblClickHere";
            // 
            // panelClick
            // 
            this.panelClick.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.panelClick, "panelClick");
            this.panelClick.Name = "panelClick";
            this.panelClick.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDoubleClick);
            this.panelClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDown);
            this.panelClick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseUp);
            // 
            // tableBottom
            // 
            resources.ApplyResources(this.tableBottom, "tableBottom");
            this.tableBottom.Controls.Add(this.txtLog, 0, 1);
            this.tableBottom.Controls.Add(this.lblResult, 0, 0);
            this.tableBottom.Name = "tableBottom";
            // 
            // txtLog
            // 
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // chkShowDoubleClick
            // 
            resources.ApplyResources(this.chkShowDoubleClick, "chkShowDoubleClick");
            this.chkShowDoubleClick.Checked = true;
            this.chkShowDoubleClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDoubleClick.Name = "chkShowDoubleClick";
            this.chkShowDoubleClick.UseVisualStyleBackColor = true;
            // 
            // chkShowSingleClick
            // 
            resources.ApplyResources(this.chkShowSingleClick, "chkShowSingleClick");
            this.chkShowSingleClick.Checked = true;
            this.chkShowSingleClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowSingleClick.Name = "chkShowSingleClick";
            this.chkShowSingleClick.UseVisualStyleBackColor = true;
            // 
            // chkShowDown
            // 
            resources.ApplyResources(this.chkShowDown, "chkShowDown");
            this.chkShowDown.Checked = true;
            this.chkShowDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDown.Name = "chkShowDown";
            this.chkShowDown.UseVisualStyleBackColor = true;
            // 
            // chkShowUp
            // 
            resources.ApplyResources(this.chkShowUp, "chkShowUp");
            this.chkShowUp.Checked = true;
            this.chkShowUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowUp.Name = "chkShowUp";
            this.chkShowUp.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // chkShowWheel
            // 
            resources.ApplyResources(this.chkShowWheel, "chkShowWheel");
            this.chkShowWheel.Checked = true;
            this.chkShowWheel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowWheel.Name = "chkShowWheel";
            this.chkShowWheel.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            resources.ApplyResources(this.btnInfo, "btnInfo");
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.chkShowWheel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkShowUp);
            this.Controls.Add(this.chkShowDown);
            this.Controls.Add(this.chkShowSingleClick);
            this.Controls.Add(this.chkShowDoubleClick);
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tableTop.ResumeLayout(false);
            this.tableTop.PerformLayout();
            this.tableBottom.ResumeLayout(false);
            this.tableBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelClick;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblClickHere;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkShowDoubleClick;
        private System.Windows.Forms.CheckBox chkShowSingleClick;
        private System.Windows.Forms.CheckBox chkShowDown;
        private System.Windows.Forms.CheckBox chkShowUp;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkShowWheel;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.TableLayoutPanel tableBottom;
        private System.Windows.Forms.Button btnInfo;
    }
}

