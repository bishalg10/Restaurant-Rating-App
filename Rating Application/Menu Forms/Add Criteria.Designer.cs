
namespace Rating_Application.Menu_Forms
{
    partial class Add_Criteria
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
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.lblAddCriteria = new System.Windows.Forms.Label();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeListColor = new System.Windows.Forms.Button();
            this.btnManageList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCriteria = new System.Windows.Forms.Panel();
            this.criteriaDataGrid = new System.Windows.Forms.DataGridView();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCriteria
            // 
            this.txtCriteria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriteria.Location = new System.Drawing.Point(105, 38);
            this.txtCriteria.Multiline = true;
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(254, 37);
            this.txtCriteria.TabIndex = 0;
            // 
            // lblAddCriteria
            // 
            this.lblAddCriteria.AutoSize = true;
            this.lblAddCriteria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCriteria.Location = new System.Drawing.Point(25, 39);
            this.lblAddCriteria.Name = "lblAddCriteria";
            this.lblAddCriteria.Size = new System.Drawing.Size(64, 21);
            this.lblAddCriteria.TabIndex = 1;
            this.lblAddCriteria.Text = "Critera";
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriteria.Location = new System.Drawing.Point(390, 39);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(248, 36);
            this.btnAddCriteria.TabIndex = 2;
            this.btnAddCriteria.Text = "Add";
            this.btnAddCriteria.UseVisualStyleBackColor = true;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeListColor);
            this.groupBox1.Controls.Add(this.btnManageList);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(387, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnChangeListColor
            // 
            this.btnChangeListColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeListColor.Location = new System.Drawing.Point(3, 123);
            this.btnChangeListColor.Name = "btnChangeListColor";
            this.btnChangeListColor.Size = new System.Drawing.Size(258, 50);
            this.btnChangeListColor.TabIndex = 3;
            this.btnChangeListColor.Text = "Change ListBox Color";
            this.btnChangeListColor.UseVisualStyleBackColor = true;
            this.btnChangeListColor.Click += new System.EventHandler(this.btnChangeListColor_Click);
            // 
            // btnManageList
            // 
            this.btnManageList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageList.Location = new System.Drawing.Point(3, 73);
            this.btnManageList.Name = "btnManageList";
            this.btnManageList.Size = new System.Drawing.Size(258, 50);
            this.btnManageList.TabIndex = 2;
            this.btnManageList.Text = "Manage ListBox";
            this.btnManageList.UseVisualStyleBackColor = true;
            this.btnManageList.Click += new System.EventHandler(this.btnManageList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(3, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(258, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Criteria";
            // 
            // panelCriteria
            // 
            this.panelCriteria.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCriteria.Controls.Add(this.criteriaDataGrid);
            this.panelCriteria.Controls.Add(this.label1);
            this.panelCriteria.Controls.Add(this.txtCriteria);
            this.panelCriteria.Controls.Add(this.groupBox1);
            this.panelCriteria.Controls.Add(this.lblAddCriteria);
            this.panelCriteria.Controls.Add(this.btnAddCriteria);
            this.panelCriteria.Location = new System.Drawing.Point(39, 34);
            this.panelCriteria.Name = "panelCriteria";
            this.panelCriteria.Size = new System.Drawing.Size(674, 404);
            this.panelCriteria.TabIndex = 6;
            // 
            // criteriaDataGrid
            // 
            this.criteriaDataGrid.AllowUserToAddRows = false;
            this.criteriaDataGrid.AllowUserToDeleteRows = false;
            this.criteriaDataGrid.AllowUserToResizeColumns = false;
            this.criteriaDataGrid.AllowUserToResizeRows = false;
            this.criteriaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criteriaDataGrid.Location = new System.Drawing.Point(29, 159);
            this.criteriaDataGrid.Name = "criteriaDataGrid";
            this.criteriaDataGrid.Size = new System.Drawing.Size(322, 216);
            this.criteriaDataGrid.TabIndex = 6;
            // 
            // Add_Criteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.panelCriteria);
            this.Name = "Add_Criteria";
            this.Text = "Add_Criteria";
            this.groupBox1.ResumeLayout(false);
            this.panelCriteria.ResumeLayout(false);
            this.panelCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Label lblAddCriteria;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeListColor;
        private System.Windows.Forms.Button btnManageList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCriteria;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.DataGridView criteriaDataGrid;
    }
}