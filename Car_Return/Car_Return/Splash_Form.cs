using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Return
{
    public partial class Splash_Form : Form
    {
        int i = 0;
        public Splash_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 100)
            {
                progressBar1.Value = i++;
            }
            else
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK; // Signal that splash is done
            }

        }

        private void Splash_Form_Load(object sender, EventArgs e)
        {
            
            timer1.Start(); // Start the timer when the splash form loads
        }
    }
}
