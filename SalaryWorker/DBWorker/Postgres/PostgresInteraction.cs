using SalaryWorker.DBWorker.Entities;
using SalaryWorker.DBWorker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace SalaryWorker.DBWorker.Postgres
{
    class PostgresInteraction : DBInteraction
    {
        private static NpgsqlConnection connection;
        private static PostgresInteraction instance = null;

        private PostgresInteraction(DBConnection connection)
        {
            try
            {
                PostgresInteraction.connection = new NpgsqlConnection(connection.ConnectionString);
            }
            catch (Exception)
            {

            }
        }

        public static PostgresInteraction GetInstance(DBConnection connection)
        {
            if (instance == null)
                instance = new PostgresInteraction(connection);
            return instance;
        }

        public static PostgresInteraction GetInstance()
        {
            if (instance == null)
                instance = new PostgresInteraction(PostgresConnection.GetConnection());
            return instance;
        }

        public override bool addCalculation(Calculation calculation)
        {
            return false;
        }

        public override bool addDepartment(Department department)
        {
            try
            {
                string query = "INSERT INTO department VALUES(DEFAULT, @p1);";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("p1", department.Name);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public override bool addEmployee(Employee employee)
        {
            try
            {
                string query = "INSERT INTO employee VALUES(DEFAULT, @p1, @p2, @p3, @p4, @p5);";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("p1", employee.Passport);
                command.Parameters.AddWithValue("p2", employee.Birthday);
                command.Parameters.AddWithValue("p3", employee.Employment);
                command.Parameters.AddWithValue("p4", employee.Profession.Id);
                command.Parameters.AddWithValue("p5", employee.Department.Id);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public override bool addPayout(Payout payout)
        {
            return false;
        }

        public override bool addProfession(Rates profession)
        {
            try
            {
                string query = "add_prof";
                connection.Open();
                connection.ReloadTypes();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                /*NpgsqlParameter parameter = new NpgsqlParameter("name_prof", System.Data.DbType.String);
                parameter.Value = profession.Profession.Name;
                NpgsqlParameter parameter2 = new NpgsqlParameter("pays", System.Data.DbType.Decimal);
                parameter2.Value = profession.PayPerHour;*/
                command.Parameters.AddWithValue("name_prof", profession.Profession.Name);
                command.Parameters.AddWithValue("pays", profession.PayPerHour);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public override bool addRates(Rates rates)
        {
            return false;
        }

        public override bool changeCalculation(Calculation oldCalc, Calculation newCalc)
        {
            return false;
        }

        public override bool changeRates(Rates n)
        {
            try
            {
                Console.WriteLine(n);
                string query = "UPDATE rates SET pay_for_hour = @p1 WHERE id_rate = @p2;";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("p1", n.PayPerHour);
                command.Parameters.AddWithValue("p2", n.Id);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public override bool deleteCalculation(Calculation calculation)
        {
            return false;
        }

        public override bool deleteDepartment(Department department)
        {
            return false;
        }

        public override bool deleteEmployee(Employee employee)
        {
            try
            {
                Console.WriteLine(employee);
                string query = "DELETE FROM employee WHERE id_empl = @p1;";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("p1", employee.Id);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public override bool deletePayout(Payout payout)
        {
            return false;
        }

        public override bool deleteProfession(Profession profession)
        {
            return false;
        }

        public override bool deleteRates(Rates rates)
        {
            return false;
        }

        public override List<Rates> getAllRates()
        {
            try
            {
                List<Rates> list = new List<Rates>();
                string query = "SELECT * FROM rates_with_prof;";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    list.Add(new Rates((int)read[0], (decimal)read[1], (DateTime)read[2], new Profession((int)read[3], (string)read[4]))); ;
                }
                connection.Close();
                return list;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public override List<Profession> getAllProfession()
        {
            try
            {
                List<Profession> list = new List<Profession>();
                string query = "SELECT * FROM profession;";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    list.Add(new Profession((int)read[0], (string)read[1]));
                }
                connection.Close();
                return list;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public override List<Employee> getBadEmployees()
        {
            return null;
        }

        public override List<Employee> getEmployeeByDepartmentName(string name)
        {
            return null;
        }

        public override List<Department> getAllDepartment()
        {
            try
            {
                List<Department> list = new List<Department>();
                string query = "SELECT * FROM department;";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader read = command.ExecuteReader();
                while(read.Read())
                {
                    list.Add(new Department((int)read[0], (string)read[1]));
                }
                connection.Close();
                return list;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public override List<Payroll> getMonthlyPayroll(int month, int year)
        {
            try
            {
                List<Payroll> list = new List<Payroll>();
                string query = "SELECT * FROM payroll WHERE _month = @p1 AND _year = @p2;";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("p1", month);
                command.Parameters.AddWithValue("p2", year);
                NpgsqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    list.Add(new Payroll((int)read[0], (string)read[1], (decimal)read[4], (string)read[2], (string)read[3]));
                }
                connection.Close();
                return list;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public override Employee getEmployeeById(int id)
        {
            return new Employee();
        }

        public override Employee getEmployeeByPassport(string passport)
        {
            return new Employee();
        }

        public override List<Employee> getAllEmployees()
        {
            try
            {
                List<Employee> list = new List<Employee>();
                string query = "SELECT * FROM employee_list;";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    Profession profession = new Profession((int)read[6], (string)read[7]);
                    Department department = new Department((int)read[4], (string)read[5]);

                    list.Add(new Employee((int)read[0], (string)read[1], (DateTime)read[2], profession, department, (DateTime)read[2]));
                }
                connection.Close();
                return list;
            }
            catch (PostgresException e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, e.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
