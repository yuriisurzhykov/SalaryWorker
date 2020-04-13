using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class BadEmployee : Employee
    {
        public int AmountHours { get; set; }
        public BadEmployee() : base()
        {
            AmountHours = 0;
        }

        public BadEmployee(int id, 
                           string passport, 
                           DateTime birthday, 
                           Profession profession, 
                           Department department, 
                           DateTime employment,
                           int amountHours) : base(id, passport, birthday, profession, department, employment)
        {
            this.AmountHours = amountHours;
        }

        public override string ToString()
        {
            return base.ToString().Remove(base.ToString().Length - 1, 1) + ", amountHours: " + AmountHours + " }";
        }

    }
}
