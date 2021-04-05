using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Rating_Application
{
    public partial class Home : Form
    {
        //Declaring the fields
        private Form currentOpenForm;
        private IconButton currentBtn;
        //private Panel leftBorderBtn;
      //  private Panel leftBorderSubMenu;
        

        //Constructors
        public Home()
        {
            InitializeComponent();
            customizeDesign();
            panelLogout.Visible = false;
            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7, 60);
            //panelMenuBar.Controls.Add(leftBorderBtn);

            //leftBorderSubMenu = new Panel();
            //leftBorderSubMenu.Size = new Size(7, 60);
            //panelReportSubMenu.Controls.Add(leftBorderSubMenu);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        String username;
        public Home(String  s)
        {
            InitializeComponent();
            username = s;
        }

        //timer property displays the current date and time
        private void Home_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            btnLogo.ImageLocation = "logo.png";
            pictureBoxLogo.ImageLocation = "waiter-wearing-face-mask-serving.jpg";
            if (username == "admin")
            {
                btnFeedback.Hide();             //Hides feedback section when the user is admin
                btnHelp.Hide();
                btnDocumentation.Hide();
                btnAboutUs.Hide();
                panelHelpSubMenu.Hide();
                hideSubMenu();
                this.Text = "Admin Panel";
                lblLogUser.Text = username;
            }
            else
            {                                   //Hides Report,Criteria,Report menu bar when the user is customer
                hideSubMenu();
                panelReportSubMenu.Hide();
                btnAddCriteria.Hide();
                btnRateReport.Hide();
                btnReport.Hide();
                btnChartReport.Hide();
                this.Text = "Customer Panel";
                lblLogUser.Text = username;
                lblWelcome.Text = "Welcome to Rating system";
            }
        }

        //Hides the sub menu bar
        private void customizeDesign()
        {
            panelReportSubMenu.Visible = false;
            panelHelpSubMenu.Visible = false;
        }

        //If one sub menu is open another is not highlighted
        private void hideSubMenu()
        {
            if (panelReportSubMenu.Visible == true)
                panelReportSubMenu.Visible = false;

            if (panelHelpSubMenu.Visible == true)
                panelHelpSubMenu.Visible = false;
        }

        //Setting the sub menu with panel
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //RGB color for the open current menu indicator
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(245, 229, 2);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(9, 179, 20);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(168, 9, 179);
        }

        //Methods
        private void ActivateSubMenuButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //butttons
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

               
                //Icon Current Child Form
                iconCurrentForm.IconChar = currentBtn.IconChar;
                iconCurrentForm.IconColor = color;
            }
        }
        private void ActivateMenuButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //butttons
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border button
                //leftBorderBtn.BackColor = color;
               // leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
               // leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentForm.IconChar = currentBtn.IconChar;
                iconCurrentForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 31, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void OpenMenuForm(Form childForm)
        {
            if (currentOpenForm != null)
            {
                //open  only form
                currentOpenForm.Close();
            }
            currentOpenForm = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelDisplayForm.Controls.Add(childForm);
            panelDisplayForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleCurrentForm.Text = childForm.Text;

        }

        private void Reset()
        {
            DisableButton();
            //leftBorderBtn.Visible = false;
            iconCurrentForm.IconChar = IconChar.Home;
            iconCurrentForm.IconColor = Color.MistyRose;
            lblTitleCurrentForm.Text = "Home";
        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            currentOpenForm.Close();
            Reset();
        }

        //Generate report sub menu
        private void btnReport_Click(object sender, EventArgs e)
        {
            lblTitleCurrentForm.Text = "Report";
            ActivateMenuButton(sender, RGBColors.color1);
            showSubMenu(panelReportSubMenu);
            this.Size = new Size(1200, 650);
        }
        private void btnRateReport_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color5);
            OpenMenuForm(new Menu_Forms.Rating_Report());
            this.Size = new Size(1450,680);
        }

        private void btnChartReport_Click(object sender, EventArgs e)
        {
            lblTitleCurrentForm.Text = "Help";
            ActivateSubMenuButton(sender, RGBColors.color6);
            OpenMenuForm(new Menu_Forms.Chart_Report()); 
                this.Size = new Size(1400, 500);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color1);
            showSubMenu(panelHelpSubMenu);

        }
        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color5);
            OpenMenuForm(new Menu_Forms.Documentation());
            this.Size = new Size(650, 620);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            ActivateSubMenuButton(sender, RGBColors.color5);
            OpenMenuForm(new Menu_Forms.About_Us());
            this.Size = new Size(650, 620);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitleCurrentForm.Text = "Home";
            if (currentOpenForm != null) { currentOpenForm.Close(); }
            
            ActivateMenuButton(sender, RGBColors.color2);
            this.Size = new Size(1200, 650);
        
        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color3);
            hideSubMenu();
            OpenMenuForm(new Menu_Forms.Add_Criteria());
            this.Size = new Size(900, 600);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            ActivateMenuButton(sender, RGBColors.color4);
            hideSubMenu();
            OpenMenuForm(new Menu_Forms.Feedback());
            this.Size = new Size(730, 820);
            this.Top = 100;
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
        //Displaying Date and Time in the Home section
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
            lblTime.Text = DateTime.Now.ToLongDateString();
            
        }

        //Exit the window form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize the window form
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
           // Login login = new Login();
            //login.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            landingTimer.Enabled = true;

        }

        private void landingTimer_Tick(object sender, EventArgs e)
        {
            panelLogout.Visible = true;
            panelLogout.Width += 20;
            if (panelLogout.Width > 150)
            {
                panelLogout.Enabled = false;
                landingTimer.Stop();
                Landing_Page LandingPage = new Landing_Page();
                LandingPage.Show();
                LandingPage.FormClosing += (obj, args) => { this.Close(); };
                this.Hide();
                this.Close();
                
            }
            
        }
    }
}
