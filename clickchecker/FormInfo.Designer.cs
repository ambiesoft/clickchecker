
namespace clickchecker
{
    partial class FormInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.linkWebPage = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.linkDonate = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(232, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // linkWebPage
            // 
            this.linkWebPage.AutoSize = true;
            this.linkWebPage.Location = new System.Drawing.Point(33, 56);
            this.linkWebPage.Name = "linkWebPage";
            this.linkWebPage.Size = new System.Drawing.Size(60, 14);
            this.linkWebPage.TabIndex = 200;
            this.linkWebPage.TabStop = true;
            this.linkWebPage.Text = "Web Page";
            this.linkWebPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebPage_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(33, 24);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 14);
            this.lblVersion.TabIndex = 100;
            // 
            // linkDonate
            // 
            this.linkDonate.AutoSize = true;
            this.linkDonate.Location = new System.Drawing.Point(33, 81);
            this.linkDonate.Name = "linkDonate";
            this.linkDonate.Size = new System.Drawing.Size(45, 14);
            this.linkDonate.TabIndex = 300;
            this.linkDonate.TabStop = true;
            this.linkDonate.Text = "&Donate";
            this.linkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonate_LinkClicked);
            // 
            // FormInfo
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(341, 150);
            this.Controls.Add(this.linkDonate);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.linkWebPage);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.LinkLabel linkWebPage;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkDonate;
    }
}