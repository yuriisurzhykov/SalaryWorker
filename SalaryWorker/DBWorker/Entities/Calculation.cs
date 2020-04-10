using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Calculation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AmountHours { get; set; }
        public int EmployeeId { get; set; }

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
