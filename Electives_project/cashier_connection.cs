using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electives_project
{
    internal class cashier_connection
    {
        public string cashier_connectionString = "Server=Nott\\SQLEXPRESS;Database=ELECTIVES_DB;Trusted_Connection=True;";
        public SqlConnection cashier_sql_connection;
        public SqlCommand cashier_sql_command;
        public string cashier_sql = null;

        public void cashier_connString()
        {
            cashier_sql_connection = new SqlConnection(cashier_connectionString);
            if (cashier_sql_connection.State == ConnectionState.Closed)
                cashier_sql_connection.Open();
        }

        public void cashier_cmd(string sql)
        {
            // Use the string 'sql' passed from the interface to initialize the command
            cashier_sql_command = new SqlCommand(sql, cashier_sql_connection);
            cashier_sql_command.CommandType = CommandType.Text;
            cashier_sql_command.Parameters.Clear();
        }
    }
}
