/*
 * Program.cs
 * by slade73
 * http://sourceforge.net/users/slade73
*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BulkImageConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}