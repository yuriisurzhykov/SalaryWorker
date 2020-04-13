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
        bool addPayout(Payout payout);
        bool deletePayout(Payout payout);
        bool upadtePayout(Payout payout);
    }
}
