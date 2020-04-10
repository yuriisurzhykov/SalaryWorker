using SalaryWorker.DBWorker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Interfaces
{
    interface EmployeeDao
    {
        int addEmployee(Employee employee);
        void deleteEmployee(Employee employee);
        List<Employee> getBadEmployees();
        List<Employee> getEmployeeByDepartmentName(string name);
    }
}
