using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryWorker.Forms
{
    public partial class GeneralStatement : Form
    {
        public GeneralStatement()
        {
            InitializeComponent();
            for(int i = DateTime.Now.Year; i > 2000; i--)
            {
                year_comboBox.Items.Add(i);
            }
        }

        private void GeneralStatement_Load(object sender, EventArgs e)
        {
            
        }

        private void Generate_Click(object sender, EventArgs e)
        {

        }
    }
}
