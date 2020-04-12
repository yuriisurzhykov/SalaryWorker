using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryWorker.Forms
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            mainTabControl.Selected += MainTabControl_Selected;
        }

        private void MainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "/[0-9]/";
        }
    }
}
