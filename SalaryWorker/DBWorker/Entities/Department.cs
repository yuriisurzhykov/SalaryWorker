using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department()
        {
            Id = 0;
            Name = "";
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
