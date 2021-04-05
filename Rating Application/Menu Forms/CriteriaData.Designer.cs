
namespace Rating_Application.Menu_Forms
{
    partial class CriteriaData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonDissatisfied = new System.Windows.Forms.RadioButton();
            this.radioButtonGood = new System.Windows.Forms.RadioButton();
            this.radioButtonAverage = new System.Windows.Forms.RadioButton();
            this.radioButtonExcellent = new System.Windows.Forms.RadioButton();
            this.criteriaNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonDissatisfied
            // 
            this.radioButtonDissatisfied.AutoSize = true;
            this.radioButtonDissatisfied.Location = new System.Drawing.Point(456, 15);
            this.radioButtonDissatisfied.Name = "radioButtonDissatisfied";
            this.radioButtonDissatisfied.Size = new System.Drawing.Size(14, 13);
            this.radioButtonDissatisfied.TabIndex = 9;
            this.radioButtonDissatisfied.TabStop = true;
            this.radioButtonDissatisfied.Tag = "1";
            this.radioButtonDissatisfied.UseVisualStyleBackColor = true;
            // 
            // radioButtonGood
            // 
            this.radioButtonGood.AutoSize = true;
            this.radioButtonGood.Location = new System.Drawing.Point(365, 15);
            this.radioButtonGood.Name = "radioButtonGood";
            this.radioButtonGood.Size = new System.Drawing.Size(14, 13);
            this.radioButtonGood.TabIndex = 8;
            this.radioButtonGood.TabStop = true;
            this.radioButtonGood.Tag = "2";
            this.radioButtonGood.UseVisualStyleBackColor = true;
            // 
            // radioButtonAverage
            // 
            this.radioButtonAverage.AutoSize = true;
            this.radioButtonAverage.Location = new System.Drawing.Point(276, 15);
            this.radioButtonAverage.Name = "radioButtonAverage";
            this.radioButtonAverage.Size = new System.Drawing.Size(14, 13);
            this.radioButtonAverage.TabIndex = 7;
            this.radioButtonAverage.TabStop = true;
            this.radioButtonAverage.Tag = "3";
            this.radioButtonAverage.UseVisualStyleBackColor = true;
            // 
            // radioButtonExcellent
            // 
            this.radioButtonExcellent.AutoSize = true;
            this.radioButtonExcellent.Location = new System.Drawing.Point(180, 15);
            this.radioButtonExcellent.Name = "radioButtonExcellent";
            this.radioButtonExcellent.Size = new System.Drawing.Size(14, 13);
            this.radioButtonExcellent.TabIndex = 6;
            this.radioButtonExcellent.TabStop = true;
            this.radioButtonExcellent.Tag = "4";
            this.radioButtonExcellent.UseVisualStyleBackColor = true;
            // 
            // criteriaNameLabel
            // 
            this.criteriaNameLabel.AutoSize = true;
            this.criteriaNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaNameLabel.Location = new System.Drawing.Point(3, 10);
            this.criteriaNameLabel.Name = "criteriaNameLabel";
            this.criteriaNameLabel.Size = new System.Drawing.Size(105, 20);
            this.criteriaNameLabel.TabIndex = 5;
            this.criteriaNameLabel.Text = "Criteria Name";
            // 
            // CriteriaData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonDissatisfied);
            this.Controls.Add(this.radioButtonGood);
            this.Controls.Add(this.radioButtonAverage);
            this.Controls.Add(this.radioButtonExcellent);
            this.Controls.Add(this.criteriaNameLabel);
            this.Name = "CriteriaData";
            this.Size = new System.Drawing.Size(514, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDissatisfied;
        private System.Windows.Forms.RadioButton radioButtonGood;
        private System.Windows.Forms.RadioButton radioButtonAverage;
        private System.Windows.Forms.RadioButton radioButtonExcellent;
        private System.Windows.Forms.Label criteriaNameLabel;
    }
}
