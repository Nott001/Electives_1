using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electives_project
{
    internal class employee_connection
    {
        // Initializes public variables
        public String cashier_connectionString = null;
        public SqlConnection cashier_sql_connection;
        public SqlCommand cashier_sql_command;
        public DataSet cashier_sql_dataset;
        public SqlDataAdapter cashier_sql_dataadapter;
        public string cashier_sql = null;

        public void cashier_connString()
        {
            cashier_sql_connection = new SqlConnection();
            cashier_connectionString =
                        "Server=Nott\\SQLEXPRESS;\n" +
                        "Database=ELECTIVES_DB;\n" +
                        "Trusted_Connection=True;";
            cashier_sql_connection = new SqlConnection(cashier_connectionString);
            cashier_sql_connection.ConnectionString = cashier_connectionString;
            cashier_sql_connection.Open();
        }

        public void cashier_cmd()
        {
            cashier_sql_command = new SqlCommand(cashier_sql, cashier_sql_connection);
            cashier_sql_command.CommandType = CommandType.Text;
        }
    }
}
