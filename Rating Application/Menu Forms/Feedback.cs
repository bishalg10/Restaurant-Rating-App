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
using System.Text.RegularExpressions;

namespace Rating_Application.Menu_Forms
{
    public partial class Feedback : Form
    {
        //Open the files for read and write
        string userRatingDataPath = "../../Resources/UserRatingData.csv";
        string criteriasPath = "../../Resources/criterias.csv";
        List<string> criterias = new List<string> { };
        
        public Feedback()
        {
            InitializeComponent();
            if (File.Exists(criteriasPath))
            {
                loadCriterias();
            }
            populateTable();
        }

        //Load data from the criterias.csv file
        private void loadCriterias()
        {
            using (StreamReader sr = File.OpenText(criteriasPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    criterias.Add(line);
                }
            }
        }

        //Load criterias data in the cell
        private void populateTable() { 
            flowLayoutPanelFeedback.Controls.Clear();
            foreach (string criteria in criterias)
            {
                CriteriaData ci = new CriteriaData();
                ci.Criteria = criteria;
                flowLayoutPanelFeedback.Controls.Add(ci);
            }
        }

        //Clear all the fields on if requirement are meet after submit button
        private void resetForm()
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            foreach (CriteriaData ci in flowLayoutPanelFeedback.Controls)
            {
                foreach (Control control in ci.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radio = (RadioButton)control;
                        radio.Checked = false;
                    }
                }
            }
        }

       //Append the user data to UserRatingData.csv file or create new file
        private void updateData(string data)
        {
            StreamWriter sw;
            if (File.Exists(userRatingDataPath))
            {
                sw = File.AppendText(userRatingDataPath);
            }
            else
            {
                sw = File.CreateText(criteriasPath);
            }
            sw.WriteLine(data);
            sw.Close();
        }

        //Submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            //DateTime properties
            var date = DateTime.Now;
            String Time = date.ToLongTimeString();
            String Date = date.ToString("yy-MM-dd");
            string name = txtName.Text;
            string number = txtContact.Text;
            string email = txtEmail.Text;
            string data = name + "," + number + "," + email + "," + Date + ","+Time;

            if (name == "" || number == "" || email == "")
            {
                MessageBox.Show("Please fill out all the fields!", "Empty user detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(email, pattern))
            {
                foreach (CriteriaData ci in flowLayoutPanelFeedback.Controls)
                {
                    string criteria = ci.Criteria;
                    RadioButton checkedButton = ci.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    if (checkedButton is null)
                    {
                        MessageBox.Show("Please rate all the criterias!", "Unchecked radio button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string rating = checkedButton.Tag.ToString();
                    data = data + "," + rating;
                }
            }
            else
            {
                MessageBox.Show("Invalid  email address");
                return;
            }
            MessageBox.Show("Your feedback has been recorded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateData(data);
            resetForm();  
        }
        private void Feedback_Load(object sender, EventArgs e)
        {
            currentTimer.Start();
        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
            lblTime.Text = DateTime.Now.ToLongDateString();
        }
    }
}
