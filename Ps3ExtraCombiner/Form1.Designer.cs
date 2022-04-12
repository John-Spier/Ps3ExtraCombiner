namespace Ps3ExtraCombiner
{
    partial class frmPs3Ren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPs3Ren));
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnOutputSelect = new System.Windows.Forms.Button();
            this.btnInputSelect = new System.Windows.Forms.Button();
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.btnStartRecursive = new System.Windows.Forms.Button();
            this.btnStartNonRecursive = new System.Windows.Forms.Button();
            this.listLogger = new System.Windows.Forms.ListBox();
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(10, 10);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(361, 20);
            this.txtOutputDir.TabIndex = 0;
            // 
            // btnOutputSelect
            // 
            this.btnOutputSelect.Location = new System.Drawing.Point(377, 9);
            this.btnOutputSelect.Name = "btnOutputSelect";
            this.btnOutputSelect.Size = new System.Drawing.Size(164, 21);
            this.btnOutputSelect.TabIndex = 1;
            this.btnOutputSelect.Text = "Select Output PS3_EXTRA Dir";
            this.btnOutputSelect.UseVisualStyleBackColor = true;
            this.btnOutputSelect.Click += new System.EventHandler(this.btnOutputSelect_Click);
            // 
            // btnInputSelect
            // 
            this.btnInputSelect.Location = new System.Drawing.Point(377, 35);
            this.btnInputSelect.Name = "btnInputSelect";
            this.btnInputSelect.Size = new System.Drawing.Size(164, 21);
            this.btnInputSelect.TabIndex = 3;
            this.btnInputSelect.Text = "Select Input Game(s) Dir";
            this.btnInputSelect.UseVisualStyleBackColor = true;
            this.btnInputSelect.Click += new System.EventHandler(this.btnInputSelect_Click);
            // 
            // txtInputDir
            // 
            this.txtInputDir.Location = new System.Drawing.Point(10, 36);
            this.txtInputDir.Name = "txtInputDir";
            this.txtInputDir.Size = new System.Drawing.Size(361, 20);
            this.txtInputDir.TabIndex = 2;
            // 
            // btnStartRecursive
            // 
            this.btnStartRecursive.Location = new System.Drawing.Point(10, 63);
            this.btnStartRecursive.Name = "btnStartRecursive";
            this.btnStartRecursive.Size = new System.Drawing.Size(361, 23);
            this.btnStartRecursive.TabIndex = 4;
            this.btnStartRecursive.Text = "Start Recursively";
            this.btnStartRecursive.UseVisualStyleBackColor = true;
            this.btnStartRecursive.Click += new System.EventHandler(this.btnStartRecursive_Click);
            // 
            // btnStartNonRecursive
            // 
            this.btnStartNonRecursive.Location = new System.Drawing.Point(377, 63);
            this.btnStartNonRecursive.Name = "btnStartNonRecursive";
            this.btnStartNonRecursive.Size = new System.Drawing.Size(164, 23);
            this.btnStartNonRecursive.TabIndex = 5;
            this.btnStartNonRecursive.Text = "Start Non-Recursively";
            this.btnStartNonRecursive.UseVisualStyleBackColor = true;
            this.btnStartNonRecursive.Click += new System.EventHandler(this.btnStartNonRecursive_Click);
            // 
            // listLogger
            // 
            this.listLogger.FormattingEnabled = true;
            this.listLogger.Location = new System.Drawing.Point(13, 100);
            this.listLogger.Name = "listLogger";
            this.listLogger.Size = new System.Drawing.Size(527, 225);
            this.listLogger.TabIndex = 6;
            // 
            // frmPs3Ren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 335);
            this.Controls.Add(this.listLogger);
            this.Controls.Add(this.btnStartNonRecursive);
            this.Controls.Add(this.btnStartRecursive);
            this.Controls.Add(this.btnInputSelect);
            this.Controls.Add(this.txtInputDir);
            this.Controls.Add(this.btnOutputSelect);
            this.Controls.Add(this.txtOutputDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPs3Ren";
            this.Text = "PS3_EXTRA Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Button btnOutputSelect;
        private System.Windows.Forms.Button btnInputSelect;
        private System.Windows.Forms.TextBox txtInputDir;
        private System.Windows.Forms.Button btnStartRecursive;
        private System.Windows.Forms.Button btnStartNonRecursive;
        private System.Windows.Forms.ListBox listLogger;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
    }
}

