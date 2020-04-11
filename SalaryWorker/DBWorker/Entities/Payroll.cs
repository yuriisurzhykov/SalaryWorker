using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Payroll
    {
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public Payout Payout { get; set; }
        public Department Department { get; set; }
        public Profession Profession { get; set; }

        public Payroll()
        {
            Employee = new Employee();
            Payout = new Payout();
            Department = new Department();
            Profession = new Profession();
        }

        public Payroll(Employee employee, Payout payout, Department department, Profession profession)
        {
            Employee = employee;
            Payout = payout;
            Department = department;
            Profession = profession;
        }

        public Payroll(int id, string emplPass, decimal payout, string depName, string profName)
        {
            ID = id;
            Employee = new Employee();
            Employee.Passport = emplPass;
            Payout = new Payout();
            Payout.IssuedBy = payout;
            Department = new Department();
            Department.Name = depName;
            Profession = new Profession();
            Profession.Name = profName;
        }
    }
}
