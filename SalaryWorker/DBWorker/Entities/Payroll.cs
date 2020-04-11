using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Payroll
    {
        public string EmployeePassport { get; set; }
        public float Payout { get; set; }
        public string DepartmentName { get; set; }
        public string ProfessionName { get; set; }
    }
}
