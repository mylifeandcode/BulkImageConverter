/*
 * frmFileExists.cs
 * by slade73
 * http://sourceforge.net/users/slade73
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace slade73.Forms
{
    /// <summary>
    /// A form for prompting the user when a file to be written already exists
    /// </summary>
    public partial class frmFileExists : Form
    {
        public enum OverwriteOption
        {
            Unspecified,
            AlwaysOverwrite,
            AlwaysSkip
        }

        protected bool _overwrite;

        #region Properties
        /// <summary>
        /// Specifies whether or not the file in question should be overwritten
        /// </summary>
        public bool Overwrite
        {
            get { return _overwrite; }
        }

        /// <summary>
        /// Specifies whether ot not the selected option should be used everytime a file to be written already 
        /// exists
        /// </summary>
        public bool AlwaysUseSelectedOption
        {
            get { return chkAlwaysUseSelected.Checked; }
        }

        /// <summary>
        /// The name of the file to ask the user for a decision to overwrite or skip
        /// </summary>
        public string Filename
        {
            get { return lblFilename.Text; }
            set { lblFilename.Text = value; }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Filename">The name of the file in question</param>
        public frmFileExists(string Filename)
        {
            InitializeComponent();
            _overwrite = false;
            lblFilename.Text = Filename;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            _overwrite = false;
            this.Close();
        }

        private void btnOverwrite_Click(object sender, EventArgs e)
        {
            _overwrite = true;
            this.Close();
        }

        private void frmFileExists_Activated(object sender, EventArgs e)
        {
            _overwrite = false;
        }
    }
}