using SalaryWorker.DBWorker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker
{
    interface DBInteraction
    {
        int addEmployee(Employee employee);
        void deleteEmployee(Employee employee);
        int addPayout(Payout payout);
        void deletePayout(Payout payout);
        int addDepartment(Department department);
        void deleteDepartment(Department department);
    }
}
