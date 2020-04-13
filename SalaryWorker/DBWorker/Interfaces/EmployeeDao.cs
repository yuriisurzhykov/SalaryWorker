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
        bool addEmployee(Employee employee);
        bool deleteEmployee(Employee employee);
        Employee getEmployeeById(int id);
        Employee getEmployeeByPassport(string passport);
        List<Employee> getAllEmployees();
        List<BadEmployee> getBadEmployees(int month, int year);
        List<Employee> getEmployeeByDepartmentName(string name);
    }
}
