using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Rating_Application.Menu_Forms
{
    public partial class Add_Criteria : Form
    {
        //Open the files for read and write
        string criteriasPath = "../../Resources/Criterias.csv";
        string userRatingDataPath = "../../Resources/UserRatingData.csv";
        List<String> allCriteriasList = new List<String>();

        public Add_Criteria()
        {
            InitializeComponent();
            LoadColumnPreCursors();
            LoadCriteriaDataTable();
        }

        private bool checkExists(string fieldName)
        {
            foreach (DataGridViewRow row in criteriaDataGrid.Rows) // loop through all rows of dataGridView
            {
                string current = row.Cells[0].Value.ToString().ToLower(); // Get value of current cell of row

                if (fieldName.ToLower() == current)
                {
                    return true;
                }
            }
            return false;
        }

        //Update csv file when a new criteria is added
        public void MakeNewCSV()
        {
            string path = criteriasPath;
            StreamWriter fieldsWriter = new StreamWriter(path);

            int count_row = criteriaDataGrid.RowCount;
            int count_cell = criteriaDataGrid.Rows[0].Cells.Count;
            String newDataField = "";
            for (int row = 0; row <= count_row - 1; row++)
            {
                for (int column = 0; column <= count_cell - 1; column++)
                {
                    var value = criteriaDataGrid.Rows[row].Cells[column].Value;
                    newDataField = newDataField + value.ToString() + ",";
                    newDataField = newDataField + "\r";
                }
            }
            fieldsWriter.Write(newDataField);
            fieldsWriter.Close();
        }

        //Creates a columns to the datagridview table
        public void LoadColumnPreCursors()
        {
            int rowCount = criteriaDataGrid.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                if (criteriaDataGrid.Rows[0].IsNewRow == false)
                    criteriaDataGrid.Rows.RemoveAt(0);
            }
            criteriaDataGrid.ColumnCount = 1;
            criteriaDataGrid.Columns[0].Name = "Criteria";
            criteriaDataGrid.Columns["Criteria"].Width = 347;
            criteriaDataGrid.Columns["Criteria"].ReadOnly = true;
            criteriaDataGrid.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
        }

        //Load the Criteria.csv file data in the datagridview table
        public void LoadCriteriaDataTable()
        {
            criteriaDataGrid.Rows.Clear();
            allCriteriasList = new List<String>();
            string[] allCriteriaFields = File.ReadAllLines(criteriasPath);
            ArrayList rows = new ArrayList();
            string[] values;
            for (int i = 0; i < allCriteriaFields.Length; i++)
            {
                values = (allCriteriaFields[i].ToString().Split('\n'));
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Replace(",", "").Trim();
                    rows.Add(row[j]);
                }
                criteriaDataGrid.Rows.Add(rows[i]);
                allCriteriasList.Add(rows[i].ToString());
            }
        }

        //Clears whole csv file and Add new new updated criterias values
        public void MakeNewAddCsv(string message)
        {
            MessageBox.Show(message);
            string fields = "";
            int countFields = 0;
            foreach (String field in allCriteriasList)
            {
                fields = fields + field;
                countFields++;
                if (countFields <= allCriteriasList.Count)
                {
                    fields = fields + ",";
                }
            }
            string line = "Name,Number,Email,Date,Time," + fields + "\n";
            txtCriteria.Text = "";
            File.WriteAllText(userRatingDataPath, line);
        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            string newField = txtCriteria.Text;
            if (newField.Length == 0) // Check if field name is empty
            {
                MessageBox.Show("Please enter field name.", "Empty field name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!checkExists(newField))
                {
                    criteriaDataGrid.Rows.Add(newField);
                    MakeNewCSV();
                    LoadCriteriaDataTable();
                    MakeNewAddCsv("Criteria Added successfully");
                }
                else
                {
                    MessageBox.Show("The field name you have entered already exists.", "Duplicate field name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RemoveNewCsv(string message)
        {
            MessageBox.Show(message);
            string fields = "";
            int countFields = 0;
            foreach (String field in allCriteriasList)
            {
                fields = fields + field;
                countFields++;
                if (countFields <= allCriteriasList.Count - 1)
                {
                    fields = fields + ",";
                }

            }
            string line = "Name,Number,Email,Date,Time," + fields + "\n";
            txtCriteria.Text = "";
            File.WriteAllText(userRatingDataPath, line);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = criteriaDataGrid.CurrentCell.RowIndex;
            criteriaDataGrid.Rows.RemoveAt(rowIndex);
            MakeNewCSV();
            LoadCriteriaDataTable();
            RemoveNewCsv(" Criteria Removed successfully.");
        }

        private void btnManageList_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                criteriaDataGrid.Font = fontDialog.Font;
            }
        }

        private void btnChangeListColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                criteriaDataGrid.BackColor = colorDialog.Color;
            }
        }
    }
 }
