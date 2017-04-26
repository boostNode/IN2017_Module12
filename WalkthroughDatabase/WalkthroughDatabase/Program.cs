/*
 *  Author: Troy Davis
 *  Project: Module12 - WalkthroughDatabase
 *      - Software Development Fundamentals Lesson 6
 *        -- ???
 *
 *      - see: https://msdn.microsoft.com/ro-ro/library/ms233763(v=vs.110).aspx
 *             
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 20, 2017 
 *  Revision: Original
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkthroughDatabase
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
            Application.Run(new Form1());
        }
    }
}
