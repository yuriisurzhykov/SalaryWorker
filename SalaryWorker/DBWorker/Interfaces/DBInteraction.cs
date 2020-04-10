using SalaryWorker.DBWorker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Interfaces
{
    abstract class DBInteraction : DepartmentDao, CalculationDao, EmployeeDao, PayoutDao, ProfessionDao, RatesDao
    {
        protected CalculationDao CalculationDao { get; set; }

        public DBInteraction(DBConnection connection)
        {

        }

        public abstract int addCalculation(Calculation calculation);

        public abstract int addDepartment(Department department);

        public abstract int addEmployee(Employee employee);

        public abstract int addPayout(Payout payout);

        public abstract bool changeCalculation(Calculation oldCalc, Calculation newCalc);

        public abstract void deleteCalculation(Calculation calculation);

        public abstract void deleteDepartment(Department department);

        public abstract void deleteEmployee(Employee employee);

        public abstract void deletePayout(Payout payout);

        public abstract List<Employee> getBadEmployees();

        public abstract List<Employee> getEmployeeByDepartmentName(string name);
        public abstract void addRates(Rates rates);
        public abstract void deleteRates(Rates rates);
        public abstract List<Rates> getAll();
        public abstract void addProfession(Profession profession);
        public abstract void deleteProfession(Profession profession);
        public abstract List<Profession> getAllProfession();

        List<Department> DepartmentDao.getAll()
        {
            throw new NotImplementedException();
        }
    }
}
