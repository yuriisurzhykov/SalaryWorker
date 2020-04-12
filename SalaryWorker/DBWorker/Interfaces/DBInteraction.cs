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

        public abstract bool addCalculation(Calculation calculation);

        public abstract bool addDepartment(Department department);

        public abstract bool addEmployee(Employee employee);

        public abstract bool addPayout(Payout payout);

        public abstract bool changeCalculation(Calculation oldCalc, Calculation newCalc);

        public abstract bool deleteCalculation(Calculation calculation);

        public abstract bool deleteDepartment(Department department);

        public abstract bool deleteEmployee(Employee employee);

        public abstract bool deletePayout(Payout payout);

        public abstract List<Employee> getBadEmployees();

        public abstract List<Employee> getEmployeeByDepartmentName(string name);
        public abstract bool addRates(Rates rates);
        public abstract bool deleteRates(Rates rates);
        public abstract List<Rates> getAllRates();
        public abstract bool addProfession(Rates profession);
        public abstract bool deleteProfession(Profession profession);
        public abstract List<Profession> getAllProfession();

        public abstract List<Department> getAllDepartment();
        public abstract bool changeRates(Rates n);
        public abstract List<Payroll> getMonthlyPayroll(int month, int year);
        public abstract Employee getEmployeeById(int id);
        public abstract Employee getEmployeeByPassport(string passport);
        public abstract List<Employee> getAllEmployees();
    }
}
