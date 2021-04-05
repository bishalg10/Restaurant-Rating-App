using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating_Application.Menu_Forms
{
    public partial class CriteriaData : UserControl
    {
        public CriteriaData()
        {
            InitializeComponent();
        }
        private string criteria;

        public string Criteria
        {
            get { return criteria; }
            set { criteria = value; criteriaNameLabel.Text = value; }
        }

    }
}
