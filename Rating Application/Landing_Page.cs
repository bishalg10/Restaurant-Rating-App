using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating_Application
{
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            panelTimer.Width += 1;
            if (panelTimer.Width > 444)
            {
                timer.Stop();
                Login loginPage = new Login();
                loginPage.Show();
                loginPage.FormClosing += (obj, args) => { this.Close(); };
                this.Hide();
            }
            
        }

        private void Landing_Page_Load(object sender, EventArgs e)
        {
            landingPicture.ImageLocation = "woman-menu.jpg";
        }

        private void landingPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
