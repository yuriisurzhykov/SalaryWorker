using SalaryWorker.DBWorker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Interfaces
{
    interface PayoutDao
    {
        int addPayout(Payout payout);
        void deletePayout(Payout payout);
    }
}
