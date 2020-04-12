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
        bool addRates(Rates rates);
        bool deleteRates(Rates rates);
        bool changeRates(Rates n);
        List<Rates> getAllRates();
    }
}
