/*================================================================================================
 * App Name: Movie streaming order Form
 * Author's name: Jinwook Jung
 * App creation Date: 17 April 2015
 * App Desription: This App show user's movie of preference and enable user to process payment and 
 *                 streaming service.
 *===============================================================================================
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
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
            Application.Run(new SplashForm());
        }
    }
}
