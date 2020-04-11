using SalaryWorker.DBWorker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Interfaces
{
    interface CalculationDao
    {
        bool addCalculation(Calculation calculation);
        bool deleteCalculation(Calculation calculation);
        bool changeCalculation(Calculation oldCalc, Calculation newCalc);
    }
}
