
namespace Rating_Application.Menu_Forms
{
    partial class Documentation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDocument = new System.Windows.Forms.Label();
            this.DocPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.DocPicture);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(34, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 331);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 37);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "The images below shows the manual for using the application more efficiently.";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocument.ForeColor = System.Drawing.Color.LightGray;
            this.lblDocument.Location = new System.Drawing.Point(12, 68);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(156, 22);
            this.lblDocument.TabIndex = 1;
            this.lblDocument.Text = "Documantation";
            // 
            // DocPicture
            // 
            this.DocPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DocPicture.Location = new System.Drawing.Point(12, 58);
            this.DocPicture.Name = "DocPicture";
            this.DocPicture.Size = new System.Drawing.Size(729, 261);
            this.DocPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DocPicture.TabIndex = 3;
            this.DocPicture.TabStop = false;
            // 
            // Documentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.panel1);
            this.Name = "Documentation";
            this.Text = "Documentation";
            this.Load += new System.EventHandler(this.Documentation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox DocPicture;
    }
}