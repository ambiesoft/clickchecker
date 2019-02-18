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
            this.panelClick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClick.BackColor = System.Drawing.Color.Blue;
            this.panelClick.Location = new System.Drawing.Point(12, 25);
            this.panelClick.Name = "panelClick";
            this.panelClick.Size = new System.Drawing.Size(549, 145);
            this.panelClick.TabIndex = 0;
            this.panelClick.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDoubleClick);
            this.panelClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDown);
            this.panelClick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseUp);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 205);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(549, 195);
            this.txtLog.TabIndex = 1;
            // 
            // lblClickHere
            // 
            this.lblClickHere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClickHere.AutoSize = true;
            this.lblClickHere.Location = new System.Drawing.Point(9, 9);
            this.lblClickHere.Name = "lblClickHere";
            this.lblClickHere.Size = new System.Drawing.Size(173, 13);
            this.lblClickHere.TabIndex = 0;
            this.lblClickHere.Text = "Click mouse button in the blue area";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 189);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "&Result:";
            // 
            // chkShowDoubleClick
            // 
            this.chkShowDoubleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowDoubleClick.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowDoubleClick.AutoSize = true;
            this.chkShowDoubleClick.Checked = true;
            this.chkShowDoubleClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDoubleClick.Location = new System.Drawing.Point(117, 406);
            this.chkShowDoubleClick.Name = "chkShowDoubleClick";
            this.chkShowDoubleClick.Size = new System.Drawing.Size(104, 23);
            this.chkShowDoubleClick.TabIndex = 2;
            this.chkShowDoubleClick.Text = "Show &DoubleClick";
            this.chkShowDoubleClick.UseVisualStyleBackColor = true;
            // 
            // chkShowSingleClick
            // 
            this.chkShowSingleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowSingleClick.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowSingleClick.AutoSize = true;
            this.chkShowSingleClick.Checked = true;
            this.chkShowSingleClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowSingleClick.Location = new System.Drawing.Point(12, 406);
            this.chkShowSingleClick.Name = "chkShowSingleClick";
            this.chkShowSingleClick.Size = new System.Drawing.Size(99, 23);
            this.chkShowSingleClick.TabIndex = 3;
            this.chkShowSingleClick.Text = "Show &SingleClick";
            this.chkShowSingleClick.UseVisualStyleBackColor = true;
            // 
            // chkShowDown
            // 
            this.chkShowDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowDown.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowDown.AutoSize = true;
            this.chkShowDown.Checked = true;
            this.chkShowDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDown.Location = new System.Drawing.Point(227, 406);
            this.chkShowDown.Name = "chkShowDown";
            this.chkShowDown.Size = new System.Drawing.Size(75, 23);
            this.chkShowDown.TabIndex = 4;
            this.chkShowDown.Text = "Show Do&wn";
            this.chkShowDown.UseVisualStyleBackColor = true;
            // 
            // chkShowUp
            // 
            this.chkShowUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowUp.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowUp.AutoSize = true;
            this.chkShowUp.Checked = true;
            this.chkShowUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowUp.Location = new System.Drawing.Point(308, 406);
            this.chkShowUp.Name = "chkShowUp";
            this.chkShowUp.Size = new System.Drawing.Size(61, 23);
            this.chkShowUp.TabIndex = 4;
            this.chkShowUp.Text = "Show &Up";
            this.chkShowUp.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(486, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 434);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkShowUp);
            this.Controls.Add(this.chkShowDown);
            this.Controls.Add(this.chkShowSingleClick);
            this.Controls.Add(this.chkShowDoubleClick);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblClickHere);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panelClick);
            this.MinimumSize = new System.Drawing.Size(479, 368);
            this.Name = "FormMain";
            this.Text = "clickchecker";
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

