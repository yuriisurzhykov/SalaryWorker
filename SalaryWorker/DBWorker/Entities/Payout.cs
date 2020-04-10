using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NpgsqlTypes;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Payout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float IssuedBy { get; set; }
        public int EmployeeId { get; set; }

        public Payout()
        {
            Id = 0;
            Date = DateTime.Now;
            IssuedBy = 0;
            EmployeeId = 0;
        }

        public Payout(int id, DateTime date, float issuedBy, int employeeId)
        {
            Id = id;
            Date = date;
            IssuedBy = issuedBy;
            EmployeeId = employeeId;
        }
    }
}
