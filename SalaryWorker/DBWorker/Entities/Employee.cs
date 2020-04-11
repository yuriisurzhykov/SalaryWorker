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
        public Profession Profession { get; set; }
        public Department Department { get; set; }
        public DateTime Employment { get; set; }

        public Employee()
        {
            Id = 0;
            Passport = "";
            Birthday = DateTime.MinValue;
            Profession = new Profession();
            Department = new Department();
            Employment = DateTime.MinValue;
        }

        public Employee(int id, string passport, DateTime birthday, Profession profession, Department department, DateTime employment)
        {
            Id = id;
            Passport = passport;
            Birthday = birthday;
            Profession = profession;
            Department = department;
            Employment = employment;
        }

        public override string ToString()
        {
            return "Employee: {" +
                "id: " + Id + ", " +
                "passport: " + Passport + ", " +
                "birthday: " + Birthday + ", " +
                "professionId: " + Profession + ", " +
                "departmentId: " + Department + ", " +
                "employment: " + Employment +
                "} ";
        }
    }
}
