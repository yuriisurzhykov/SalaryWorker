using SalaryWorker.DBWorker.Postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryWorker
{
    static class Program
    {

        public static string connectionString = "Server=localhost;User Id=postgres;Password=12345678;Database=SalaryWorker;";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CreateConnection());
            PostgresConnection.CreateConnectionString();
        }
    }
}
