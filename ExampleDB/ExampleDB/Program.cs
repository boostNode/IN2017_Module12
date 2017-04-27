/*
 *  Author: Troy Davis
 *  Project: Module12 - ExampleDB - Windows Form Application (with database)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 25, 2017 
 *  Revision: Original
 *  
 *  For more information on displaying related data on Windows Forms, see:
 *      https://msdn.microsoft.com/en-us/library/57tx3hhe(v=vs.110)
 *      
 *  Language description data sourced from Techopedia:
 *      https://www.techopedia.com/dictionary
 *      
 */

using System;
using System.Windows.Forms;

namespace ExampleDB
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
