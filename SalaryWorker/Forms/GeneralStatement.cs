using SalaryWorker.DBWorker.Entities;
using SalaryWorker.DBWorker.Postgres;
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
        private bool isMonthSelect = false;
        private bool isYearSelect = false;
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
            listView1.Items.Clear();
            int month = month_comboBox.SelectedIndex + 1;
            int year = (int)year_comboBox.SelectedItem;
            Console.WriteLine(month + ", " + year);
            List<Payroll> payroll = PostgresInteraction.GetInstance()
                                                       .getMonthlyPayroll(month, year);
            foreach(var item in payroll)
            {
                ListViewItem item1 = new ListViewItem(item.ID.ToString());
                item1.SubItems.AddRange(new string[] { item.Employee.Passport, item.Department.Name, item.Profession.Name, item.Payout.IssuedBy.ToString() });
                listView1.Items.Add(item1);
            }
        }

        private void Month_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isMonthSelect = true;
        }

        private void Year_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isYearSelect = true;
        }
    }
}
