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

namespace Rating_Application.Menu_Forms
{
    public partial class Chart_Report : Form
    {
        string userRatingDataPath = "../../Resources/UserRatingData.csv";
        string criteriasPath = "../../Resources/criterias.csv";

        public Chart_Report()
        {
            InitializeComponent();
            LoadChart();
        }
        public void LoadChart()
        {
            // Get data from criterias.txt
            string[] fields = File.ReadAllText(criteriasPath).Split(',');
            int countFields = fields.Length;

            // Get data from userRatingData.csv
            string[] reviews = File.ReadAllLines(userRatingDataPath);

            // X and Y values of chart
            List<string> xValues = new List<string>();
            List<double> yValues = new List<double>();

            // Saving field names for chart
            foreach (string field in fields)
            {
                xValues.Add(field);
            }

            int totalReviews = reviews.Length;
            double[] totalPoints = new double[countFields];

            for (int j = 1; j < totalReviews; j++) // Looping through all reviews (rows)
            {
                string[] review = reviews[j].Split(',');
                int count = 0;
                for (int i = 5; i < review.Length; i++) // Looping through all fields (columns)
                {
                    totalPoints[count] += Convert.ToDouble(review[i]); // Storing total score in each field
                    count++;
                }
            }

            // Calculating average score of each field
            foreach (double average in totalPoints)
            {
                yValues.Add(average / (totalReviews - 1));
            }

            // Plotting in graph
            barChart.Series["Mean Value"].Points.DataBindXY(xValues, yValues);
        }
    }
}
