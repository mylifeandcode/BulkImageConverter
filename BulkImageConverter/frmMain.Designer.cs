namespace BulkImageConverter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblImageDirectory = new System.Windows.Forms.Label();
            this.txtImageDirectory = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxProgress = new System.Windows.Forms.GroupBox();
            this.prgStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbxConversion = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.chkDeleteAfterConvert = new System.Windows.Forms.CheckBox();
            this.cboOutputTypes = new System.Windows.Forms.ComboBox();
            this.cboSourceTypes = new System.Windows.Forms.ComboBox();
            this.lnkDonate = new System.Windows.Forms.LinkLabel();
            this.chkIncludeSubDirs = new System.Windows.Forms.CheckBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.gbxProgress.SuspendLayout();
            this.gbxConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(392, 404);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(519, 76);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblImageDirectory
            // 
            this.lblImageDirectory.AutoSize = true;
            this.lblImageDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageDirectory.Location = new System.Drawing.Point(12, 44);
            this.lblImageDirectory.Name = "lblImageDirectory";
            this.lblImageDirectory.Size = new System.Drawing.Size(463, 26);
            this.lblImageDirectory.TabIndex = 2;
            this.lblImageDirectory.Text = "Step 1 - Select the directory which contains the image files you want to convert." +
    "\r\n(Type the full directory path below, or click the button to the right to brows" +
    "e.)";
            // 
            // txtImageDirectory
            // 
            this.txtImageDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageDirectory.Location = new System.Drawing.Point(12, 76);
            this.txtImageDirectory.Name = "txtImageDirectory";
            this.txtImageDirectory.Size = new System.Drawing.Size(499, 20);
            this.txtImageDirectory.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(473, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxProgress
            // 
            this.gbxProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProgress.Controls.Add(this.prgStatus);
            this.gbxProgress.Controls.Add(this.lblStatus);
            this.gbxProgress.Location = new System.Drawing.Point(12, 258);
            this.gbxProgress.Name = "gbxProgress";
            this.gbxProgress.Size = new System.Drawing.Size(536, 100);
            this.gbxProgress.TabIndex = 4;
            this.gbxProgress.TabStop = false;
            this.gbxProgress.Text = "Progress";
            // 
            // prgStatus
            // 
            this.prgStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prgStatus.Location = new System.Drawing.Point(9, 63);
            this.prgStatus.Name = "prgStatus";
            this.prgStatus.Size = new System.Drawing.Size(520, 23);
            this.prgStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Black;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(6, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(523, 18);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Inactive";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxConversion
            // 
            this.gbxConversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxConversion.Controls.Add(this.lblOutput);
            this.gbxConversion.Controls.Add(this.lblSource);
            this.gbxConversion.Controls.Add(this.chkDeleteAfterConvert);
            this.gbxConversion.Controls.Add(this.cboOutputTypes);
            this.gbxConversion.Controls.Add(this.cboSourceTypes);
            this.gbxConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConversion.Location = new System.Drawing.Point(12, 164);
            this.gbxConversion.Name = "gbxConversion";
            this.gbxConversion.Size = new System.Drawing.Size(536, 75);
            this.gbxConversion.TabIndex = 3;
            this.gbxConversion.TabStop = false;
            this.gbxConversion.Text = "Conversion";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(80, 42);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "to type";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(6, 19);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(113, 13);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Convert all files of type";
            // 
            // chkDeleteAfterConvert
            // 
            this.chkDeleteAfterConvert.Location = new System.Drawing.Point(332, 20);
            this.chkDeleteAfterConvert.Name = "chkDeleteAfterConvert";
            this.chkDeleteAfterConvert.Size = new System.Drawing.Size(197, 35);
            this.chkDeleteAfterConvert.TabIndex = 1;
            this.chkDeleteAfterConvert.Text = "Delete original files after conversion (not recommended)";
            this.chkDeleteAfterConvert.UseVisualStyleBackColor = true;
            // 
            // cboOutputTypes
            // 
            this.cboOutputTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOutputTypes.FormattingEnabled = true;
            this.cboOutputTypes.Location = new System.Drawing.Point(125, 43);
            this.cboOutputTypes.Name = "cboOutputTypes";
            this.cboOutputTypes.Size = new System.Drawing.Size(180, 21);
            this.cboOutputTypes.Sorted = true;
            this.cboOutputTypes.TabIndex = 2;
            // 
            // cboSourceTypes
            // 
            this.cboSourceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceTypes.FormattingEnabled = true;
            this.cboSourceTypes.Location = new System.Drawing.Point(125, 16);
            this.cboSourceTypes.Name = "cboSourceTypes";
            this.cboSourceTypes.Size = new System.Drawing.Size(180, 21);
            this.cboSourceTypes.Sorted = true;
            this.cboSourceTypes.TabIndex = 0;
            // 
            // lnkDonate
            // 
            this.lnkDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkDonate.AutoSize = true;
            this.lnkDonate.Location = new System.Drawing.Point(12, 409);
            this.lnkDonate.Name = "lnkDonate";
            this.lnkDonate.Size = new System.Drawing.Size(257, 13);
            this.lnkDonate.TabIndex = 5;
            this.lnkDonate.TabStop = true;
            this.lnkDonate.Text = "Found this program useful?  Please make a donation.";
            this.lnkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDonate_LinkClicked);
            // 
            // chkIncludeSubDirs
            // 
            this.chkIncludeSubDirs.AutoSize = true;
            this.chkIncludeSubDirs.Location = new System.Drawing.Point(15, 104);
            this.chkIncludeSubDirs.Name = "chkIncludeSubDirs";
            this.chkIncludeSubDirs.Size = new System.Drawing.Size(129, 17);
            this.chkIncludeSubDirs.TabIndex = 2;
            this.chkIncludeSubDirs.Text = "Include subdirectories";
            this.chkIncludeSubDirs.UseVisualStyleBackColor = true;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(12, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(500, 13);
            this.lblGreeting.TabIndex = 9;
            this.lblGreeting.Text = "Converting your images with Bulk Image Converter is easy. Just follow the steps b" +
    "elow.";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep2.Location = new System.Drawing.Point(12, 141);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(528, 13);
            this.lblStep2.TabIndex = 10;
            this.lblStep2.Text = "Step 2 - Select the type of files you want to convert, and what you want to conve" +
    "rt them to.";
            // 
            // lblStep3
            // 
            this.lblStep3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStep3.AutoSize = true;
            this.lblStep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep3.Location = new System.Drawing.Point(12, 384);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(231, 13);
            this.lblStep3.TabIndex = 11;
            this.lblStep3.Text = "Step 3 - Click the Start button to begin.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 437);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.chkIncludeSubDirs);
            this.Controls.Add(this.lnkDonate);
            this.Controls.Add(this.gbxConversion);
            this.Controls.Add(this.gbxProgress);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtImageDirectory);
            this.Controls.Add(this.lblImageDirectory);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(576, 475);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk Image Converter";
            this.gbxProgress.ResumeLayout(false);
            this.gbxConversion.ResumeLayout(false);
            this.gbxConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblImageDirectory;
        private System.Windows.Forms.TextBox txtImageDirectory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxProgress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar prgStatus;
        private System.Windows.Forms.GroupBox gbxConversion;
        private System.Windows.Forms.CheckBox chkDeleteAfterConvert;
        private System.Windows.Forms.ComboBox cboOutputTypes;
        private System.Windows.Forms.ComboBox cboSourceTypes;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.LinkLabel lnkDonate;
        private System.Windows.Forms.CheckBox chkIncludeSubDirs;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep3;
    }
}

