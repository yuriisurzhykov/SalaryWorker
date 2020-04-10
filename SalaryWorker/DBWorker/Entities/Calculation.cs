using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Calculation
    {
        private int Id { get; set; }
        private DateTime Date { get; set; }
        private int AmountHours { get; set; }
        private int EmployeeId { get; set; }

        public Calculation()
        {
            Id = 0;
            Date = DateTime.Now;
            AmountHours = 0;
            EmployeeId = 0;
        }

        public Calculation(int id, DateTime date, int amountHours, int employeeId)
        {
            Id = id;
            Date = date;
            AmountHours = amountHours;
            EmployeeId = employeeId;
        }
    }
}
