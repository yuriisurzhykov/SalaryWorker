using SalaryWorker.DBWorker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Interfaces
{
    interface RatesDao
    {
        void addRates(Rates rates);
        void deleteRates(Rates rates);
        List<Rates> getAll();
    }
}
