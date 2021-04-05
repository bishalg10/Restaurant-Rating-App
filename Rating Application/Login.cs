using System;
using System.IO;
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
    public partial class Login : Form
    {
        string userDataPath = "../../Resources/UserDatas.csv";
        Dictionary<string, Dictionary<string, string>> userData = new Dictionary<string, Dictionary<string, string>> { };

        public Login()
        {
            InitializeComponent();
            if (File.Exists(userDataPath))
            {
                LoadCredentials();
            }
        }

        private void LoadCredentials()
        {
            //Streamreader reads the file mention in userDataPath
            using (StreamReader sr = File.OpenText(userDataPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    userData.Add(data[0], new Dictionary<string, string> { { "password", data[1] }, { "role", data[2] } });
                }
                sr.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username.Equals("Username") && password.Equals("Password"))
            {
                MessageBox.Show("Please enter a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Equals("=") && password.Equals("="))
            {
                MessageBox.Show("Please enter a username and password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userData.ContainsKey(username))
                {
                    if (userData[username]["password"].Equals(password))
                    {
                        if (userData[username]["role"].Equals("admin"))
                        {
                            this.Hide();
                            Home homeForm = new Home(txtUsername.Text);
                            homeForm.Show();
                        }
                        else
                        {
                            this.Hide();
                            Home homeForm = new Home(txtUsername.Text);
                            homeForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password! Try Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Setting the moveable  window*/
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void movingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void movingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void movingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register openRegister = new Register();
            openRegister.Show();
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

        private void Login_Shown(object sender, EventArgs e)
        {
            pictureLogo.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "login-background.jpg";
            pictureLogo.ImageLocation = "logo.png";
        }
    }
}
