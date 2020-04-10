using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Profession()
        {
            Id = 0;
            Name = "";
        }

        public Profession(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
