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

        public void cashier_cmd() // Public function codes that support mssql query
        {
            cashier_sql_command = new SqlCommand(cashier_sql, cashier_sql_connection);
            cashier_sql_command.CommandType = CommandType.Text;
        }

        public void cashier_sqladapterSelect() //public function codes for mediating between C# language and the MSSQL SELECT command
        {
            cashier_sql_dataadapter = new SqlDataAdapter();
            cashier_sql_dataadapter.SelectCommand = cashier_sql_command;
            cashier_sql_command.ExecuteNonQuery();
        }

        public void cashier_sqladapterInsert() //public function codes for mediating between C# language and the MSSQL INSERT command
        {
            cashier_sql_dataadapter = new SqlDataAdapter();
            cashier_sql_dataadapter.InsertCommand = cashier_sql_command;
            cashier_sql_command.ExecuteNonQuery();
        }

        public void cashier_sqladapterDelete() //public function codes for mediating between C# language and the MSSQL DELETE command
        {
            cashier_sql_dataadapter = new SqlDataAdapter();
            cashier_sql_dataadapter.DeleteCommand = cashier_sql_command;
            cashier_sql_command.ExecuteNonQuery();
        }

        public void cashier_sqladapterUpdate() //public function codes for mediating between C# language and the MSSQL UPDATE command
        {
            cashier_sql_dataadapter = new SqlDataAdapter();
            cashier_sql_dataadapter.UpdateCommand = cashier_sql_command;
            cashier_sql_command.ExecuteNonQuery();
        }

        public void cashier_sqldatasetSELECT() //codes for mirroring the contents of the database inside MSSQL to C# or Visual Studio
        {
            cashier_sql_dataset = new DataSet();
            cashier_sql_dataadapter.Fill(cashier_sql_dataset, "Sale");
        }
    }
}
