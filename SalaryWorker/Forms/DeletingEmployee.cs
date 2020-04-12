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
using static System.Windows.Forms.ListView;

namespace SalaryWorker.Forms
{
    public partial class DeletingEmployee : Form
    {
        private int amountSelected = 0;
        public DeletingEmployee()
        {
            InitializeComponent();
        }

        private void DeletingEmployee_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            List<Employee> employees = PostgresInteraction.GetInstance().getAllEmployees();
            foreach (var item in employees)
            {
                ListViewItem item1 = new ListViewItem(item.Id.ToString());
                item1.SubItems.AddRange(new string[] { item.Passport, item.Birthday.ToShortDateString(), item.Profession.Name, item.Department.Name, item.Employment.ToShortDateString() });
                listView1.Items.Add(item1);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListViewItem temp = listView1.FindItemWithText("FD123456");
            listView1.Items.Remove(listView1.FindItemWithText("FD123456"));
            ListViewItem temp2 = listView1.Items[0];
            listView1.Items[0] = temp;
            listView1.Items.Add(temp2);
            listView1.ItemCheck += ListView1_ItemCheck;
        }

        private void ListView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            amount.Text = e.Index.ToString();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
