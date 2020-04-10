using SalaryWorker.DBWorker.Entities;
using SalaryWorker.DBWorker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace SalaryWorker.DBWorker.Postgres
{
    class PostgresInteraction : DBInteraction
    {
        private static NpgsqlConnection connection;
        public PostgresInteraction(DBConnection connection) : base(connection)
        {
            try
            {
                PostgresInteraction.connection = new NpgsqlConnection(connection.ConnectionString);
            }
            catch (Exception)
            {

            }
        }

        public override int addCalculation(Calculation calculation)
        {
            return 1;
        }

        public override int addDepartment(Department department)
        {
            string query = "INSERT INTO department VALUES(DEFAULT, @p1);";
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("p1", department.Name);
            int result = (int)command.ExecuteScalar();
            connection.Close();
            return result;
        }

        public override int addEmployee(Employee employee)
        {
            string query = "INSERT INTO employee VALUES(DEFAULT, @p1, @p2, @p3, @p4, @p5);";
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("p1", employee.Passport);
            command.Parameters.AddWithValue("p2", employee.Birthday);
            command.Parameters.AddWithValue("p3", employee.Employment);
            command.Parameters.AddWithValue("p4", employee.ProfessionId);
            command.Parameters.AddWithValue("p5", employee.DepartmentId);
            int result = (int)command.ExecuteScalar();
            connection.Close();
            return result;
        }

        public override int addPayout(Payout payout)
        {
            return 1;
        }

        public override void addProfession(Profession profession)
        {
            string query = "INSERT INTO department VALUES(DEFAULT, @p1);";
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("p1", profession.Name);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public override void addRates(Rates rates)
        {
            
        }

        public override bool changeCalculation(Calculation oldCalc, Calculation newCalc)
        {
            return false;
        }

        public override void deleteCalculation(Calculation calculation)
        {
            
        }

        public override void deleteDepartment(Department department)
        {
            
        }

        public override void deleteEmployee(Employee employee)
        {
            
        }

        public override void deletePayout(Payout payout)
        {
            
        }

        public override void deleteProfession(Profession profession)
        {
            
        }

        public override void deleteRates(Rates rates)
        {
            
        }

        public override List<Rates> getAll()
        {
            return null;
        }

        public override List<Profession> getAllProfession()
        {
            return null;
        }

        public override List<Employee> getBadEmployees()
        {
            return null;
        }

        public override List<Employee> getEmployeeByDepartmentName(string name)
        {
            return null;
        }
    }
}
