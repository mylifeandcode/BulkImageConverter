/*
 * frmMain.cs
 * by slade73
 * http://sourceforge.net/users/slade73
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using slade73.Gfx;
using slade73.Forms;


namespace BulkImageConverter
{
    public partial class frmMain : Form
    {
        private enum OverwriteOption
        {
            Unspecified,
            AlwaysOverwrite,
            AlwaysSkip
        }


        public frmMain()
        {
            InitializeComponent();
            SetupControls();
            this.Text = "Bulk Image Converter v" + Application.ProductVersion + " by slade73";
            ImageOps.OnImageConversionStart += new ImageOps.ImageEvent(ImageOps_OnImageConversionStart);
            ImageOps.OnImageConversionComplete += new ImageOps.ImageEvent(ImageOps_OnImageConversionComplete);
        }


        void ImageOps_OnImageConversionStart(ImageOpsEventArgs args)
        {
            lblStatus.Text = "Converting " + args.ImageFilename + "...";
            lblStatus.Refresh();
            //prgStatus.Value++;
        }


        void ImageOps_OnImageConversionComplete(ImageOpsEventArgs args)
        {
            lblStatus.Text = "Converted " + args.ImageFilename;
            lblStatus.Refresh(); 
            prgStatus.Value++;
        }


        private void ConvertImageFiles()
        {
            ImageFormat format = null;
            string[] inputFileMasks = null;
            int totalFiles = 0;

            //Make sure we have all the information we need to proceed and that it's valid.  If not, bail.
            if (!OKToProceed()) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                //Disable input controls
                ToggleInputEnable(false);

                //If the input path ends with a backslash, remove it
                txtImageDirectory.Text = txtImageDirectory.Text.Trim();
                if (txtImageDirectory.Text.EndsWith("\\")) txtImageDirectory.Text.TrimEnd('\\');

                //Get the selected image format and associated filemasks
                format = GetSelectedOutputImageFormat();
                inputFileMasks = ImageOps.GetFileMasks(cboSourceTypes.Text);

                //Get the total number of files we will be converting

                totalFiles = GetFileCount(txtImageDirectory.Text, inputFileMasks, chkIncludeSubDirs.Checked);

                //If there are no files to convert, alert the user and bail.  Otherwise, set up the progress bar.
                if (totalFiles == 0)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("There are no files of the type you specified in the chosen directory.",
                        "No files to convert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    prgStatus.Value = 0;
                    prgStatus.Maximum = totalFiles;
                }

                lblStatus.Text = "Beginning conversion";

                ImageOps.ConvertImages(txtImageDirectory.Text,
                    chkIncludeSubDirs.Checked,
                    inputFileMasks,
                    format,
                    chkDeleteAfterConvert.Checked);

                prgStatus.Value = prgStatus.Maximum;

                this.Cursor = Cursors.Default;
                lblStatus.Text = "Conversion complete";
                MessageBox.Show("Done!", "Conversion complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "ERROR";
                this.Cursor = Cursors.Default;
                MessageBox.Show("An error has occurred:\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleInputEnable(true);
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            ConvertImageFiles();
        }


        /// <summary>
        /// Gets the appropriate type of ImageFormat based on the user's output format selection
        /// </summary>
        /// <returns>The ImageFormat object for the user's output format selection</returns>
        protected ImageFormat GetSelectedOutputImageFormat()
        {
            Type type = null;

            try
            {
                type = typeof(ImageFormat);
                return (ImageFormat)type.InvokeMember(cboOutputTypes.SelectedItem.ToString(), BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty, null, null, null);
            }
            finally
            {
                type = null;
            }
        }

        /// <summary>
        /// Determines whether or not all of the required information for converting images has been supplied and 
        /// is valid
        /// </summary>
        /// <returns>true if the required information is present and valid, false otherwise</returns>
        protected bool OKToProceed()
        {
            DialogResult delete;

            //Make sure a directory has been specified
            if (txtImageDirectory.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Please specify a directory containing images you wish to convert.",
                    "No directory specified",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            //Make sure specified directory exists
            if (!Directory.Exists(txtImageDirectory.Text))
            {
                MessageBox.Show("The directory you specifed, \"" + txtImageDirectory.Text + "\", does not exist.",
                    "Directory not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            //Make sure user has selected image formats
            if (cboSourceTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the type of image files you wish to convert.",
                    "No source image format selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboOutputTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the format to convert your image files to.",
                    "No output image format selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            //If the user has specified that the original images should be deleted after conversion, prompt to
            //confirm
            if (chkDeleteAfterConvert.Checked)
            {
                /*
                if (MessageBox.Show("You have chen to delete the original image files after they're converted.\n\nAre you sure?",
                    "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;
                */
                delete = MessageBox.Show("You have chosen to delete the original image files after they're converted.\n\n" +
                                        "This should only be done if you are sure that the converted images will be satisfactory.\n\n" +
                                        "Are you sure you want to delete the original image files after conversion?",
                    "WARNING - Please confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch(delete)
                {
                    case DialogResult.Cancel:
                        return false;

                    case DialogResult.No:
                        chkDeleteAfterConvert.Checked = false;
                        break;

                    case DialogResult.Yes:
                        break; //No change required.  Keep going.
                }
            }

            //Still here?  Everything's OK, return true.
            return true;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = null;

            try
            {
                dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() != DialogResult.Cancel)
                    txtImageDirectory.Text = dlg.SelectedPath;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dlg != null)
                    dlg.Dispose();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Sets up the controls on the form.  No kidding.
        /// </summary>
        protected void SetupControls()
        {
            PopulateImageTypeCombo(cboSourceTypes);
            PopulateImageTypeCombo(cboOutputTypes);
            //cboSourceTypes.Items = cboSourceTypes.Items;
        }


        /// <summary>
        /// Populates a ComboBox with the available ImageFormats
        /// </summary>
        /// <param name="pCombo">The ComboBox to populate</param>
        protected void PopulateImageTypeCombo(ComboBox pCombo)
        {
            PropertyInfo[] props;

            try
            {
                //Get the static properties of the ImageFormat class
                //props = typeof(System.Drawing.Imaging.ImageFormat).GetProperties(BindingFlags.Static);
                props = typeof(System.Drawing.Imaging.ImageFormat).GetProperties(BindingFlags.Static | BindingFlags.Public);

                //Loop through each property and add to the specified ComboBox
                //pCombo.Items.AddRange(props); //Can't do it this way, as ToString() returns the long name
                foreach (PropertyInfo prop in props)
                {
                    if (prop.Name != "MemoryBmp" && prop.Name != "Icon")
                        pCombo.Items.Add(prop.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to load available image types:\n\n" + ex.Message,
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                props = null;
            }

        }


        /// <summary>
        /// Gets the file extensions for the selected input ImageFormat
        /// </summary>
        /// <returns>An array of strings containing the file extensions which apply to the selected input 
        /// ImageFormat</returns>
        protected string[] GetFileMasks()
        {
            string imageType = cboSourceTypes.Text;

            try
            {
                switch (imageType)
                {
                    case "Icon":
                        return new string[] { "*.ico", "*.icon" };

                    case "Jpeg":
                        return new string[] { "*.jpg", "*.jpeg" };

                    case "Tiff":
                        return new string[] { "*.tif", "*.tiff" };

                    default:
                        return new string[] { "*." + imageType };
                }
            }
            finally
            {
                imageType = null;
            }
        }


        /// <summary>
        /// Gets the appropriate extension to use for the selected output image format
        /// </summary>
        /// <returns>A string containing the appropriate file extenstion to use for output files</returns>
        protected string GetOutputExtension()
        {
            switch (cboOutputTypes.Text)
            {
                case "Icon":
                    return "ico";

                case "Jpeg":
                    return "jpg";

                case "Tiff":
                    return "tif";

                default:
                    return cboOutputTypes.Text;
            }
        }


        /// <summary>
        /// Toggles the Enabled property of the input controls
        /// </summary>
        /// <param name="Enable">A boolean indicating whether or not the controls should be enabled</param>
        protected void ToggleInputEnable(bool Enable)
        {
            txtImageDirectory.Enabled = Enable;
            btnBrowse.Enabled = Enable;
            cboSourceTypes.Enabled = Enable;
            cboOutputTypes.Enabled = Enable;
            chkDeleteAfterConvert.Enabled = Enable;
            btnStart.Enabled = Enable;
            btnExit.Enabled = Enable;
        }


        private void lnkSourceForgeProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Open link to my SourceForge page
            System.Diagnostics.Process.Start("http://sourceforge.net/users/slade73/");
        }


        private void lnkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Open link to PayPal page to make a donation
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_xclick&business=slade73%40hotmail%2ecom&item_name=Donation%20for%20Software%20Development&no_shipping=0&no_note=1&tax=0&currency_code=USD&lc=US&bn=PP%2dDonationsBF&charset=UTF%2d8");
        }


        /// <summary>
        /// Gets the number of files from the specified directory which match the supplied filemask
        /// </summary>
        /// <param name="directory">The directory to get a file count from</param>
        /// <param name="fileMasks">The filemask(s) to count</param>
        /// <param name="includeSubDirs">Specifies whether subdirectories of the specified directory should 
        /// be included</param>
        /// <returns>The total number of files from the specified directory which match the supplied filemask</returns>
        private int GetFileCount(string directory, string[] fileMasks, bool includeSubDirs)
        {
            int totalFiles = 0;

            foreach (string fileMask in fileMasks)
            {
                totalFiles += Directory.GetFiles(directory, fileMask).Length;
            }

            //If we're including subdirectories, recursively call this function for each subdirectory
            if (includeSubDirs)
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    totalFiles += GetFileCount(dir, fileMasks, true);
                }
            }

            return totalFiles;
        }
    }
}