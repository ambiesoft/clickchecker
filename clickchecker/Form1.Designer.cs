namespace clickchecker
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // panelClick
            // 
            this.panelClick.BackColor = System.Drawing.Color.Blue;
            this.panelClick.Location = new System.Drawing.Point(12, 12);
            this.panelClick.Name = "panelClick";
            this.panelClick.Size = new System.Drawing.Size(427, 100);
            this.panelClick.TabIndex = 0;
            this.panelClick.DoubleClick += new System.EventHandler(this.panelClick_DoubleClick);
            this.panelClick.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClick_Paint);
            this.panelClick.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDoubleClick);
            this.panelClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseClick);
            this.panelClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelClick_MouseDown);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 170);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(558, 171);
            this.txtLog.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 372);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panelClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelClick;
        private System.Windows.Forms.TextBox txtLog;
    }
}

