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
        private int Id { get; set; }
        private DateTime Date { get; set; }
        private float IssuedBy { get; set; }
        private int EmployeeId { get; set; }

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
