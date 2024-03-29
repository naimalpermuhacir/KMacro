﻿using System;
using System.Windows.Forms;

namespace KOMacro
{
    static class Program
    {
        public static Form MainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new frmKOmacro();
            MainForm.TopMost = true;
            Application.Run(MainForm);
        }
    }
}
