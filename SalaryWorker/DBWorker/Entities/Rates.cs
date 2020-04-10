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
        private int Id { get; set; }
        private float PayPerHour { get; set; }
        private int ProfessionId { get; set; }
        private DateTime LastUpdate { get; set; }

        public Rates()
        {
            Id = 0;
            PayPerHour = 0;
            ProfessionId = 0;
            LastUpdate = DateTime.Now;
        }

        public Rates(int id, float payPerHour, int professionId, DateTime lastUpdate)
        {
            Id = id;
            PayPerHour = payPerHour;
            ProfessionId = professionId;
            LastUpdate = lastUpdate;
        }
    }
}
