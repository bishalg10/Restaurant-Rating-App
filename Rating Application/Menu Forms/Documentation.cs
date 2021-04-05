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
    public partial class Documentation : Form
    {
        public Documentation()
        {
            InitializeComponent();
        }

        private void Documentation_Load(object sender, EventArgs e)
        {
            DocPicture.ImageLocation = "documentaion.png";
        }
    }
}
