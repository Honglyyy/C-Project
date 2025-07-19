using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Return
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                // Step 1: Show Login Form
                loginForm login = new loginForm();
                var result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Step 2: If login succeeds, show Main Menu
                    MainMenuForm main = new MainMenuForm();
                    var mainResult = main.ShowDialog();

                    // Step 3: If logout, loop again
                    if (mainResult == DialogResult.Abort) // logout case
                        continue;
                    else
                        break; // app closed
                }
                else
                {
                    break; // login cancelled or closed
                }
            }
        }
    }
}
