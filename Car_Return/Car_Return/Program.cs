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

            // Step 1: Show Splash Screen first
            using (Splash_Form splash = new Splash_Form())
            {
                splash.ShowDialog();
            }

            // Step 2: Start login → main menu loop
            bool runApp = true;
            while (runApp)
            {
                loginForm login = new loginForm();
                var loginResult = login.ShowDialog();

                if (loginResult == DialogResult.OK)
                {
                    MainMenuForm main = new MainMenuForm();
                    var mainResult = main.ShowDialog();

                    if (mainResult == DialogResult.Abort)
                    {
                        // User clicked "Log Out" → go back to login
                        continue;
                    }
                    else
                    {
                        // MainMenu closed normally → exit app
                        runApp = false;
                    }
                }
                else
                {
                    // Login canceled or closed → exit app
                    runApp = false;
                }
            }
        }

    }
}
