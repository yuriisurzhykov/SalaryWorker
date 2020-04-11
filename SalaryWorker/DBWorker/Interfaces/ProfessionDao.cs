using SalaryWorker.DBWorker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Interfaces
{
    interface ProfessionDao
    {
        bool addProfession(Profession profession);
        bool deleteProfession(Profession profession);
        List<Profession> getAllProfession();
    }
}
