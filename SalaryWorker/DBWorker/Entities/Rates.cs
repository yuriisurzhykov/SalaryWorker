using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;

namespace SalaryWorker.DBWorker.Entities
{
    class Rates
    {
        public int Id { get; set; }
        public decimal PayPerHour { get; set; }
        public Profession Profession { get; set; }
        public DateTime LastUpdate { get; set; }

        public Rates()
        {
            Id = 0;
            PayPerHour = 0;
            Profession = new Profession();
            LastUpdate = DateTime.MinValue;
        }

        public Rates(int id, decimal payPerHour, DateTime lastUpdate, Profession profession)
        {
            Id = id;
            PayPerHour = payPerHour;
            Profession = profession;
            LastUpdate = lastUpdate;
        }

        public override string ToString()
        {
            return "Rate: {" +
                "id: " + Id + ", " +
                "passport: " + PayPerHour + ", " +
                "professionName: " + Profession.Name + ", " +
                "lastUpdate: " + LastUpdate +
                "}";
        }
    }
}
