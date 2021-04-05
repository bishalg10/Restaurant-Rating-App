using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Rating_Application.Menu_Forms
{
    public partial class Rating_Report : Form
    {
        //DataTable provides a collection of columns and rows to store data in a grid form.
        DataTable reviewDataTable = new DataTable();
        string userRatingDataPath = "../../Resources/UserRatingData.csv";
        public Rating_Report()
        {
            InitializeComponent();
        }
       
        private void Rating_Report_Load(object sender, EventArgs e)
        {
            loadCSV(userRatingDataPath);
        }

        public void loadCSV(string path)
        {
            reviewDataTable.Columns.Clear();
            reviewDataTable.Rows.Clear();
            int totalColumn = reviewDataGrid.Rows.Count;
            for(int i=0; i < totalColumn; i++)
            {
                reviewDataGrid.Rows.RemoveAt(0);
            }
            reviewDataTable = new DataTable();
            string[] readRawText = System.IO.File.ReadAllLines(path);
            string headerLines = readRawText[0];
            string[] header = headerLines.Split(',');

            if (readRawText.Length > 0)
            {
                for (int i = 0; i < header.Count(); i++)
                {
                    reviewDataTable.Columns.Add(header[i]);
                }
                for (int i = 1; i <= readRawText.Length - 1; i++)
                {
                    string[] dataWord = readRawText[i].Split(',');     //Creating an array dataWord 
                    DataRow dataRow = reviewDataTable.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in header)
                    {
                        dataRow[headerWord] = dataWord[columnIndex++];
                    }
                    reviewDataTable.Rows.Add(dataRow);
                }

            }
            reviewDataGrid.DataSource = reviewDataTable;
            this.Controls.Add(reviewDataGrid);
        }

        //Imports the CSV file and displays in the data grid table.
        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Getting path of documents folder
                openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    loadCSV(filePath);

                }
            }
        }

        private void btnLoadPrevious_Click_1(object sender, EventArgs e)
        {
            loadCSV(userRatingDataPath);
        }

        //For Sorting through Name/Contact Number/Email
        private void btnSort_Click(object sender, EventArgs e)
        {
            //Creating an objet of columns and intializing it to sort the fields accordingly 
            string selectedData = comboSelectedData.Text;
            if (selectedData == "Name(Ascending)")
            {
                reviewDataGrid.Sort(reviewDataGrid.Columns[0], ListSortDirection.Ascending);
            }
            else if (selectedData == "Name(Descending)")
            {
                reviewDataGrid.Sort(reviewDataGrid.Columns[0], ListSortDirection.Descending);
            }
            else if (selectedData == "Contact Number(Ascending)")
            {
                reviewDataGrid.Sort(reviewDataGrid.Columns[1], ListSortDirection.Ascending);
            }
            else if (selectedData == "Contact Number(Descending)")
            {
                reviewDataGrid.Sort(reviewDataGrid.Columns[1], ListSortDirection.Descending);
            }
            else if (selectedData == "Email(Ascending)")
            {
                reviewDataGrid.Sort(reviewDataGrid.Columns[2], ListSortDirection.Ascending);
            }
            else if (selectedData == "Email(Descending)")
            {
                reviewDataGrid.Sort(reviewDataGrid.Columns[2], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Select a sorting field");
            }
        }
    
        //Export the user rating data in the JSOn file
        private void btnExportJSON_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";
            saveFileDialog.FilterIndex = 0;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("JSON file exported successfully.", "Inforamtion");
                string json = JsonConvert.SerializeObject(reviewDataTable, Formatting.Indented);
                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }
    }
}
