
namespace Rating_Application.Menu_Forms
{
    partial class Rating_Report
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
            this.reviewDataGrid = new System.Windows.Forms.DataGridView();
            this.comboSelectedData = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblRatingReport = new System.Windows.Forms.Label();
            this.btnLoadPrevious = new System.Windows.Forms.Button();
            this.btnExportJSON = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblDissatisfied = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblExcellent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewDataGrid
            // 
            this.reviewDataGrid.AllowDrop = true;
            this.reviewDataGrid.AllowUserToAddRows = false;
            this.reviewDataGrid.AllowUserToDeleteRows = false;
            this.reviewDataGrid.AllowUserToResizeColumns = false;
            this.reviewDataGrid.AllowUserToResizeRows = false;
            this.reviewDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.reviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewDataGrid.Location = new System.Drawing.Point(39, 199);
            this.reviewDataGrid.Name = "reviewDataGrid";
            this.reviewDataGrid.Size = new System.Drawing.Size(1167, 265);
            this.reviewDataGrid.TabIndex = 0;
            // 
            // comboSelectedData
            // 
            this.comboSelectedData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectedData.FormattingEnabled = true;
            this.comboSelectedData.Items.AddRange(new object[] {
            "Name(Ascending)",
            "Name(Descending)",
            "Contact Number(Ascending)",
            "Contact Number(Descending)",
            "Email(Ascending)",
            "Email(Descending)",
            ""});
            this.comboSelectedData.Location = new System.Drawing.Point(32, 55);
            this.comboSelectedData.Name = "comboSelectedData";
            this.comboSelectedData.Size = new System.Drawing.Size(180, 25);
            this.comboSelectedData.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(235, 55);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 29);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImport.Location = new System.Drawing.Point(237, 496);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(165, 46);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import CSV File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblSort);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.comboSelectedData);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 113);
            this.panel1.TabIndex = 4;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(29, 25);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(99, 20);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Sorting  Field";
            // 
            // lblRatingReport
            // 
            this.lblRatingReport.AutoSize = true;
            this.lblRatingReport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingReport.ForeColor = System.Drawing.Color.White;
            this.lblRatingReport.Location = new System.Drawing.Point(35, 39);
            this.lblRatingReport.Name = "lblRatingReport";
            this.lblRatingReport.Size = new System.Drawing.Size(148, 24);
            this.lblRatingReport.TabIndex = 5;
            this.lblRatingReport.Text = "Rating Report";
            // 
            // btnLoadPrevious
            // 
            this.btnLoadPrevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadPrevious.Location = new System.Drawing.Point(42, 496);
            this.btnLoadPrevious.Name = "btnLoadPrevious";
            this.btnLoadPrevious.Size = new System.Drawing.Size(177, 46);
            this.btnLoadPrevious.TabIndex = 6;
            this.btnLoadPrevious.Text = "Load Previous Data";
            this.btnLoadPrevious.UseVisualStyleBackColor = true;
            this.btnLoadPrevious.Click += new System.EventHandler(this.btnLoadPrevious_Click_1);
            // 
            // btnExportJSON
            // 
            this.btnExportJSON.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportJSON.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExportJSON.Location = new System.Drawing.Point(425, 496);
            this.btnExportJSON.Name = "btnExportJSON";
            this.btnExportJSON.Size = new System.Drawing.Size(165, 46);
            this.btnExportJSON.TabIndex = 7;
            this.btnExportJSON.Text = "Export JSON file";
            this.btnExportJSON.UseVisualStyleBackColor = true;
            this.btnExportJSON.Click += new System.EventHandler(this.btnExportJSON_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPoint.Location = new System.Drawing.Point(682, 56);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(95, 17);
            this.lblPoint.TabIndex = 12;
            this.lblPoint.Text = "Rating Point:-";
            // 
            // lblDissatisfied
            // 
            this.lblDissatisfied.AutoSize = true;
            this.lblDissatisfied.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDissatisfied.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDissatisfied.Location = new System.Drawing.Point(1092, 56);
            this.lblDissatisfied.Name = "lblDissatisfied";
            this.lblDissatisfied.Size = new System.Drawing.Size(100, 17);
            this.lblDissatisfied.TabIndex = 11;
            this.lblDissatisfied.Text = "Dissatisfied = 1";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAverage.Location = new System.Drawing.Point(988, 56);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(86, 17);
            this.lblAverage.TabIndex = 10;
            this.lblAverage.Text = "Average = 2";
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGood.Location = new System.Drawing.Point(881, 56);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(69, 17);
            this.lblGood.TabIndex = 9;
            this.lblGood.Text = "Good = 3";
            // 
            // lblExcellent
            // 
            this.lblExcellent.AutoSize = true;
            this.lblExcellent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcellent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblExcellent.Location = new System.Drawing.Point(775, 56);
            this.lblExcellent.Name = "lblExcellent";
            this.lblExcellent.Size = new System.Drawing.Size(87, 17);
            this.lblExcellent.TabIndex = 8;
            this.lblExcellent.Text = "Excellent = 4";
            // 
            // Rating_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1232, 566);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblDissatisfied);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.lblExcellent);
            this.Controls.Add(this.btnExportJSON);
            this.Controls.Add(this.btnLoadPrevious);
            this.Controls.Add(this.lblRatingReport);
            this.Controls.Add(this.reviewDataGrid);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.panel1);
            this.Name = "Rating_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rating_Report";
            this.Load += new System.EventHandler(this.Rating_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewDataGrid;
        private System.Windows.Forms.ComboBox comboSelectedData;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblRatingReport;
        private System.Windows.Forms.Button btnLoadPrevious;
        private System.Windows.Forms.Button btnExportJSON;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblDissatisfied;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblExcellent;
    }
}