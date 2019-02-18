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
            this.panelClick = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblClickHere = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkShowDoubleClick = new System.Windows.Forms.CheckBox();
            this.chkShowSingleClick = new System.Windows.Forms.CheckBox();
            this.chkShowDown = new System.Windows.Forms.CheckBox();
            this.chkShowUp = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelClick
            // 
            resources.ApplyResources(this.panelClick, "panelClick");
            this.panelClick.BackColor = System.Drawing.Color.Blue;
            this.panelClick.Name = "panelClick";
            this.panelClick.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDoubleClick);
            this.panelClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDown);
            this.panelClick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseUp);
            // 
            // txtLog
            // 
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // lblClickHere
            // 
            resources.ApplyResources(this.lblClickHere, "lblClickHere");
            this.lblClickHere.Name = "lblClickHere";
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
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkShowUp);
            this.Controls.Add(this.chkShowDown);
            this.Controls.Add(this.chkShowSingleClick);
            this.Controls.Add(this.chkShowDoubleClick);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblClickHere);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panelClick);
            this.Name = "FormMain";
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
    }
}

