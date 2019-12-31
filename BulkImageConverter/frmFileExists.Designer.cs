namespace slade73.Forms
{
    partial class frmFileExists
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
            this.lblTheFile = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblAlreadyExists = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.chkAlwaysUseSelected = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTheFile
            // 
            this.lblTheFile.AutoSize = true;
            this.lblTheFile.Location = new System.Drawing.Point(12, 9);
            this.lblTheFile.Name = "lblTheFile";
            this.lblTheFile.Size = new System.Drawing.Size(102, 13);
            this.lblTheFile.TabIndex = 0;
            this.lblTheFile.Text = "A file with the name:";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(12, 31);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(126, 13);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "FILENAME GOES HERE";
            // 
            // lblAlreadyExists
            // 
            this.lblAlreadyExists.AutoSize = true;
            this.lblAlreadyExists.Location = new System.Drawing.Point(12, 55);
            this.lblAlreadyExists.Name = "lblAlreadyExists";
            this.lblAlreadyExists.Size = new System.Drawing.Size(208, 13);
            this.lblAlreadyExists.TabIndex = 2;
            this.lblAlreadyExists.Text = "already exists.  What would you like to do?";
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(151, 131);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(91, 23);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "&Skip this file";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Location = new System.Drawing.Point(260, 131);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(132, 23);
            this.btnOverwrite.TabIndex = 2;
            this.btnOverwrite.Text = "&Overwrite this file";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // chkAlwaysUseSelected
            // 
            this.chkAlwaysUseSelected.AutoSize = true;
            this.chkAlwaysUseSelected.Location = new System.Drawing.Point(15, 97);
            this.chkAlwaysUseSelected.Name = "chkAlwaysUseSelected";
            this.chkAlwaysUseSelected.Size = new System.Drawing.Size(295, 17);
            this.chkAlwaysUseSelected.TabIndex = 0;
            this.chkAlwaysUseSelected.Text = "&Use the selected option for every file which already exists";
            this.chkAlwaysUseSelected.UseVisualStyleBackColor = true;
            // 
            // frmFileExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 166);
            this.ControlBox = false;
            this.Controls.Add(this.chkAlwaysUseSelected);
            this.Controls.Add(this.btnOverwrite);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lblAlreadyExists);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.lblTheFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFileExists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Already Exists";
            this.Activated += new System.EventHandler(this.frmFileExists_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheFile;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblAlreadyExists;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.CheckBox chkAlwaysUseSelected;
    }
}