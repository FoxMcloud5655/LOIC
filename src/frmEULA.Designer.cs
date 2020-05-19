namespace LOIC
{
    partial class frmEULA
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
            this.txtEULA = new System.Windows.Forms.RichTextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.chkEULA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtEULA
            // 
            this.txtEULA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEULA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEULA.Location = new System.Drawing.Point(3, 0);
            this.txtEULA.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtEULA.Name = "txtEULA";
            this.txtEULA.Size = new System.Drawing.Size(1245, 721);
            this.txtEULA.TabIndex = 0;
            this.txtEULA.Text = "";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(815, 735);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(200, 55);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            this.btnDecline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDecline.Location = new System.Drawing.Point(1031, 735);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(200, 55);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.Text = "&Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            // 
            // chkEULA
            // 
            this.chkEULA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkEULA.AutoSize = true;
            this.chkEULA.Location = new System.Drawing.Point(17, 745);
            this.chkEULA.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkEULA.Name = "chkEULA";
            this.chkEULA.Size = new System.Drawing.Size(748, 36);
            this.chkEULA.TabIndex = 3;
            this.chkEULA.Text = "I have read and &understood the terms of this agreement";
            this.chkEULA.UseVisualStyleBackColor = true;
            this.chkEULA.CheckedChanged += new System.EventHandler(this.chkEULA_CheckedChanged);
            // 
            // frmEULA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1248, 935);
            this.Controls.Add(this.chkEULA);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtEULA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::LOIC.Properties.Resources.LOIC_ICO;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimumSize = new System.Drawing.Size(1280, 1023);
            this.Name = "frmEULA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Low Orbit Ion Cannon End User License Agreement (EULA)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtEULA;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.CheckBox chkEULA;
    }
}