
namespace Rating_Application.Menu_Forms
{
    partial class Feedback
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.panelFeedback = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDissatisfied = new System.Windows.Forms.Label();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblExcellent = new System.Windows.Forms.Label();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.flowLayoutPanelFeedback = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.iconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.criteriaItem1 = new Rating_Application.Menu_Forms.CriteriaData();
            this.panelFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(364, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(87, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(522, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(303, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(13, 64);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 17);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Number";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(87, 63);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(187, 21);
            this.txtContact.TabIndex = 4;
            // 
            // panelFeedback
            // 
            this.panelFeedback.BackColor = System.Drawing.Color.Lavender;
            this.panelFeedback.Controls.Add(this.panel1);
            this.panelFeedback.Controls.Add(this.lblDissatisfied);
            this.panelFeedback.Controls.Add(this.panelLine1);
            this.panelFeedback.Controls.Add(this.lblAverage);
            this.panelFeedback.Controls.Add(this.lblGood);
            this.panelFeedback.Controls.Add(this.lblExcellent);
            this.panelFeedback.Controls.Add(this.lblCriteria);
            this.panelFeedback.Controls.Add(this.flowLayoutPanelFeedback);
            this.panelFeedback.Controls.Add(this.btnSubmit);
            this.panelFeedback.Controls.Add(this.lblName);
            this.panelFeedback.Controls.Add(this.txtEmail);
            this.panelFeedback.Controls.Add(this.txtName);
            this.panelFeedback.Controls.Add(this.lblEmail);
            this.panelFeedback.Controls.Add(this.lblContact);
            this.panelFeedback.Controls.Add(this.txtContact);
            this.panelFeedback.Location = new System.Drawing.Point(49, 66);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Padding = new System.Windows.Forms.Padding(10);
            this.panelFeedback.Size = new System.Drawing.Size(676, 603);
            this.panelFeedback.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Location = new System.Drawing.Point(5, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 1);
            this.panel1.TabIndex = 14;
            // 
            // lblDissatisfied
            // 
            this.lblDissatisfied.AutoSize = true;
            this.lblDissatisfied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDissatisfied.Location = new System.Drawing.Point(523, 118);
            this.lblDissatisfied.Name = "lblDissatisfied";
            this.lblDissatisfied.Size = new System.Drawing.Size(77, 17);
            this.lblDissatisfied.TabIndex = 13;
            this.lblDissatisfied.Text = "Dissatisfied";
            // 
            // panelLine1
            // 
            this.panelLine1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelLine1.Location = new System.Drawing.Point(5, 524);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(677, 1);
            this.panelLine1.TabIndex = 14;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(406, 118);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(63, 17);
            this.lblAverage.TabIndex = 12;
            this.lblAverage.Text = "Average";
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.Location = new System.Drawing.Point(320, 118);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(46, 17);
            this.lblGood.TabIndex = 11;
            this.lblGood.Text = "Good";
            // 
            // lblExcellent
            // 
            this.lblExcellent.AutoSize = true;
            this.lblExcellent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcellent.Location = new System.Drawing.Point(199, 118);
            this.lblExcellent.Name = "lblExcellent";
            this.lblExcellent.Size = new System.Drawing.Size(64, 17);
            this.lblExcellent.TabIndex = 10;
            this.lblExcellent.Text = "Excellent";
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteria.Location = new System.Drawing.Point(22, 118);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(55, 17);
            this.lblCriteria.TabIndex = 9;
            this.lblCriteria.Text = "Criteria";
            // 
            // flowLayoutPanelFeedback
            // 
            this.flowLayoutPanelFeedback.AutoScroll = true;
            this.flowLayoutPanelFeedback.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelFeedback.Location = new System.Drawing.Point(16, 145);
            this.flowLayoutPanelFeedback.Name = "flowLayoutPanelFeedback";
            this.flowLayoutPanelFeedback.Size = new System.Drawing.Size(646, 366);
            this.flowLayoutPanelFeedback.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(517, 538);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 52);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSlogan.Location = new System.Drawing.Point(45, 20);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(278, 24);
            this.lblSlogan.TabIndex = 14;
            this.lblSlogan.Text = "Help us to improve more!!!";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(455, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(562, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 18);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Time";
            // 
            // currentTimer
            // 
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // iconCurrentForm
            // 
            this.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconCurrentForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconCurrentForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentForm.IconSize = 36;
            this.iconCurrentForm.Location = new System.Drawing.Point(520, 22);
            this.iconCurrentForm.Name = "iconCurrentForm";
            this.iconCurrentForm.Size = new System.Drawing.Size(36, 36);
            this.iconCurrentForm.TabIndex = 17;
            this.iconCurrentForm.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconPictureBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 36;
            this.iconPictureBox1.Location = new System.Drawing.Point(413, 22);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(36, 36);
            this.iconPictureBox1.TabIndex = 18;
            this.iconPictureBox1.TabStop = false;
            // 
            // criteriaItem1
            // 
            this.criteriaItem1.Criteria = null;
            this.criteriaItem1.Location = new System.Drawing.Point(4, 4);
            this.criteriaItem1.Margin = new System.Windows.Forms.Padding(4);
            this.criteriaItem1.Name = "criteriaItem1";
            this.criteriaItem1.Padding = new System.Windows.Forms.Padding(10);
            this.criteriaItem1.Size = new System.Drawing.Size(489, 23);
            this.criteriaItem1.TabIndex = 0;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(768, 702);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconCurrentForm);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.panelFeedback);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.panelFeedback.ResumeLayout(false);
            this.panelFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Panel panelFeedback;
        private System.Windows.Forms.Label lblDissatisfied;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblExcellent;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFeedback;
        private Rating_Application.Menu_Forms.CriteriaData criteriaItem1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer currentTimer;
        private FontAwesome.Sharp.IconPictureBox iconCurrentForm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panel1;
    }
}