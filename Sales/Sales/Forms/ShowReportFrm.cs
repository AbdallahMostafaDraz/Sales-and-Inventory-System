using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales.Forms
{
    public partial class ShowReportFrm2 : Form
    {
        public ShowReportFrm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            { }
            catch { }
        }

        private void ShowReportFrm2_Load(object sender, EventArgs e)
        {

        }
    }
}
