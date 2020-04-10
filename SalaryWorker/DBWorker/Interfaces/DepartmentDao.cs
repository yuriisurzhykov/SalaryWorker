using SalaryWorker.DBWorker.Entities;
using System.Collections.Generic;

namespace SalaryWorker.DBWorker.Interfaces
{
    interface DepartmentDao
    {
        int addDepartment(Department department);
        void deleteDepartment(Department department);
        List<Department> getAll();
    }
}
