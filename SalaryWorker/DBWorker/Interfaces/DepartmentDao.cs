using SalaryWorker.DBWorker.Entities;
using System.Collections.Generic;

namespace SalaryWorker.DBWorker.Interfaces
{
    interface DepartmentDao
    {
        bool addDepartment(Department department);
        bool deleteDepartment(Department department);
        List<Payroll> getMonthlyPayroll(int month, int year);
        List<Department> getAllDepartment();
    }
}
