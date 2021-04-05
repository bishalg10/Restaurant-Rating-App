
namespace Rating_Application
{
    partial class Landing_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelTimer = new System.Windows.Forms.Panel();
            this.landingPicture = new System.Windows.Forms.PictureBox();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.landingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelTimer
            // 
            this.panelTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelTimer.Location = new System.Drawing.Point(0, 479);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(7, 7);
            this.panelTimer.TabIndex = 0;
            // 
            // landingPicture
            // 
            this.landingPicture.Location = new System.Drawing.Point(3, 77);
            this.landingPicture.Name = "landingPicture";
            this.landingPicture.Size = new System.Drawing.Size(444, 398);
            this.landingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.landingPicture.TabIndex = 1;
            this.landingPicture.TabStop = false;
            this.landingPicture.Click += new System.EventHandler(this.landingPicture_Click);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(85, 39);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(289, 28);
            this.lblWelcomeUser.TabIndex = 2;
            this.lblWelcomeUser.Text = "Welcome to Rating App";
            // 
            // Landing_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 484);
            this.Controls.Add(this.lblWelcomeUser);
            this.Controls.Add(this.landingPicture);
            this.Controls.Add(this.panelTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Landing_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landing_Page";
            this.Load += new System.EventHandler(this.Landing_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.landingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.PictureBox landingPicture;
        private System.Windows.Forms.Label lblWelcomeUser;
    }
}