using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class SuperPayroll : Payroll
    {
        public DateTime Date { get; set; }

        public SuperPayroll() : base()
        {
            Date = DateTime.MinValue;
        }

        public SuperPayroll(int id, 
                            string emplPass, 
                            decimal payout, 
                            string depName, 
                            string profName, 
                            int month, 
                            int year) : base(id, emplPass, payout, depName, profName)
        {
            Date = new DateTime(year, month, 1);
        }

        public override string ToString()
        {
            return base.ToString().Remove(base.ToString().Length - 1, 1) + "," +
                        "month: " + Date.ToString() +
                        " }";
        }
    }
}
