namespace CodeBeautifier
{
    partial class Form1
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
            this.rtCode = new System.Windows.Forms.RichTextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnBeautify = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRichText = new System.Windows.Forms.TabPage();
            this.tabHtml = new System.Windows.Forms.TabPage();
            this.tabOpts = new System.Windows.Forms.TabPage();
            this.ckFontBold = new System.Windows.Forms.CheckBox();
            this.ckBackColor = new System.Windows.Forms.CheckBox();
            this.ckColor = new System.Windows.Forms.CheckBox();
            this.ckFontName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabRichText.SuspendLayout();
            this.tabHtml.SuspendLayout();
            this.tabOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtCode
            // 
            this.rtCode.AcceptsTab = true;
            this.rtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtCode.Location = new System.Drawing.Point(3, 3);
            this.rtCode.Name = "rtCode";
            this.rtCode.Size = new System.Drawing.Size(546, 326);
            this.rtCode.TabIndex = 0;
            this.rtCode.Text = "";
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(3, 3);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(546, 326);
            this.txtCode.TabIndex = 1;
            // 
            // btnBeautify
            // 
            this.btnBeautify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBeautify.Location = new System.Drawing.Point(12, 376);
            this.btnBeautify.Name = "btnBeautify";
            this.btnBeautify.Size = new System.Drawing.Size(75, 23);
            this.btnBeautify.TabIndex = 2;
            this.btnBeautify.Text = "&Beautify";
            this.btnBeautify.UseVisualStyleBackColor = true;
            this.btnBeautify.Click += new System.EventHandler(this.btnBeautify_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRichText);
            this.tabControl1.Controls.Add(this.tabHtml);
            this.tabControl1.Controls.Add(this.tabOpts);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 358);
            this.tabControl1.TabIndex = 4;
            // 
            // tabRichText
            // 
            this.tabRichText.Controls.Add(this.rtCode);
            this.tabRichText.Location = new System.Drawing.Point(4, 22);
            this.tabRichText.Name = "tabRichText";
            this.tabRichText.Padding = new System.Windows.Forms.Padding(3);
            this.tabRichText.Size = new System.Drawing.Size(552, 332);
            this.tabRichText.TabIndex = 0;
            this.tabRichText.Text = "Rich Text";
            this.tabRichText.UseVisualStyleBackColor = true;
            // 
            // tabHtml
            // 
            this.tabHtml.Controls.Add(this.txtCode);
            this.tabHtml.Location = new System.Drawing.Point(4, 22);
            this.tabHtml.Name = "tabHtml";
            this.tabHtml.Padding = new System.Windows.Forms.Padding(3);
            this.tabHtml.Size = new System.Drawing.Size(552, 332);
            this.tabHtml.TabIndex = 1;
            this.tabHtml.Text = "Formatted HTML";
            this.tabHtml.UseVisualStyleBackColor = true;
            // 
            // tabOpts
            // 
            this.tabOpts.Controls.Add(this.ckFontBold);
            this.tabOpts.Controls.Add(this.ckBackColor);
            this.tabOpts.Controls.Add(this.ckColor);
            this.tabOpts.Controls.Add(this.ckFontName);
            this.tabOpts.Controls.Add(this.label1);
            this.tabOpts.Location = new System.Drawing.Point(4, 22);
            this.tabOpts.Name = "tabOpts";
            this.tabOpts.Size = new System.Drawing.Size(552, 332);
            this.tabOpts.TabIndex = 2;
            this.tabOpts.Text = "Options";
            this.tabOpts.UseVisualStyleBackColor = true;
            // 
            // ckFontBold
            // 
            this.ckFontBold.AutoSize = true;
            this.ckFontBold.Location = new System.Drawing.Point(22, 109);
            this.ckFontBold.Name = "ckFontBold";
            this.ckFontBold.Size = new System.Drawing.Size(71, 17);
            this.ckFontBold.TabIndex = 4;
            this.ckFontBold.Text = "Font Bold";
            this.ckFontBold.UseVisualStyleBackColor = true;
            // 
            // ckBackColor
            // 
            this.ckBackColor.AutoSize = true;
            this.ckBackColor.Location = new System.Drawing.Point(22, 63);
            this.ckBackColor.Name = "ckBackColor";
            this.ckBackColor.Size = new System.Drawing.Size(78, 17);
            this.ckBackColor.TabIndex = 2;
            this.ckBackColor.Text = "Back Color";
            this.ckBackColor.UseVisualStyleBackColor = true;
            // 
            // ckColor
            // 
            this.ckColor.AutoSize = true;
            this.ckColor.Checked = true;
            this.ckColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckColor.Location = new System.Drawing.Point(22, 40);
            this.ckColor.Name = "ckColor";
            this.ckColor.Size = new System.Drawing.Size(50, 17);
            this.ckColor.TabIndex = 1;
            this.ckColor.Text = "Color";
            this.ckColor.UseVisualStyleBackColor = true;
            // 
            // ckFontName
            // 
            this.ckFontName.AutoSize = true;
            this.ckFontName.Location = new System.Drawing.Point(22, 86);
            this.ckFontName.Name = "ckFontName";
            this.ckFontName.Size = new System.Drawing.Size(78, 17);
            this.ckFontName.TabIndex = 3;
            this.ckFontName.Text = "Font Name";
            this.ckFontName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Html Format Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBeautify);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Beautifier";
            this.tabControl1.ResumeLayout(false);
            this.tabRichText.ResumeLayout(false);
            this.tabHtml.ResumeLayout(false);
            this.tabHtml.PerformLayout();
            this.tabOpts.ResumeLayout(false);
            this.tabOpts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnBeautify;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRichText;
        private System.Windows.Forms.TabPage tabHtml;
        private System.Windows.Forms.TabPage tabOpts;
        private System.Windows.Forms.CheckBox ckFontBold;
        private System.Windows.Forms.CheckBox ckBackColor;
        private System.Windows.Forms.CheckBox ckColor;
        private System.Windows.Forms.CheckBox ckFontName;
        private System.Windows.Forms.Label label1;
    }
}

