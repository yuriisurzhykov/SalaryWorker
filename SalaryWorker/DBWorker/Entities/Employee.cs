using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Employee
    {
        public int Id { get; set; }
        public string Passport { get; set; }
        public DateTime Birthday { get; set; }
        public int ProfessionId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime Employment { get; set; }

        public Employee()
        {
            Id = 0;
            Passport = "";
            Birthday = DateTime.Now;
            ProfessionId = 0;
            DepartmentId = 0;
            Employment = DateTime.Now;
        }

        public Employee(int id, string passport, DateTime birthday, int professionId, int departmentId, DateTime employment)
        {
            Id = id;
            Passport = passport;
            Birthday = birthday;
            ProfessionId = professionId;
            DepartmentId = departmentId;
            Employment = employment;
        }
    }
}
