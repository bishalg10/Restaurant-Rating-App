using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating_Application
{
    public partial class Register : Form
    {
        string userDataPath = "../../Resources/UserDatas.csv";
        List<String> allCriteriasList = new List<String>();

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //BindGrid();
            pictureRegister.ImageLocation = "register-font.jpg";
            pictureLogo.ImageLocation = "logo.png";
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text.Equals("Username") && txtPassword.Text.Equals("Password"))
            {
                MessageBox.Show("Please create a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == string.Empty && txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please create a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Please create a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please create a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(userDataPath, true);
                    sw.WriteLine(txtUsername.Text + "," + txtPassword.Text + "," + "customer");
                    this.txtUsername.Focus();
                    this.txtUsername.Clear();
                    this.txtPassword.Focus();
                    this.txtPassword.Clear();
                    MessageBox.Show("User created successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                    this.Hide();
                    Login openLogin = new Login();
                    openLogin.Show();
                }   
            }  
        }

        /* Setting the moveable  window*/
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void movingPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void movingPanel_MouseUp_1(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void movingPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbllogin_Click_1(object sender, EventArgs e)
        {
           // this.Close();
            Login openLogin = new Login();
            openLogin.Show();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login openLogin = new Login();
            openLogin.Show();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {

                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {

                txtPassword.Text = "";
            }
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void Register_Shown(object sender, EventArgs e)
        {
            pictureLogo.Focus();
        }
    }
}
