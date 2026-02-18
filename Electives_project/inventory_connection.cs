using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Electives_project
{
    internal class inventory_connection
    {
        public String inventory_connectionString = null;
        public SqlConnection inventory_sql_connection;
        public SqlCommand inventory_sql_command;
        public DataSet inventory_sql_dataset;
        public SqlDataAdapter inventory_sql_dataadapter;
        public string inventory_sql = null;


        public void inventory_connString()
        {
            inventory_sql_connection = new SqlConnection();
            inventory_connectionString = 
                "Server=Nott\\SQLEXPRESS;\n" +
                "Database=ELECTIVES_DB;\n" +
                "Trusted_Connection=True;";

            inventory_sql_connection = new SqlConnection(inventory_connectionString);
            inventory_sql_connection.ConnectionString = inventory_connectionString;
            inventory_sql_connection.Open();
        }

        public void inventory_cmd() // Public function codes that support mssql query
        {
            inventory_sql_command = new SqlCommand(inventory_sql, inventory_sql_connection);
            inventory_sql_command.CommandType = CommandType.Text;
        }

        public void inventory_sqladapterSelect() //public function codes for mediating between C# language and the MSSQL SELECT command
        {
            inventory_sql_dataadapter = new SqlDataAdapter();
            inventory_sql_dataadapter.SelectCommand = inventory_sql_command;
            inventory_sql_command.ExecuteNonQuery();
        }

        public void inventory_sqladapterInsert() //public function codes for mediating between C# language and the MSSQL INSERT command
        {
            inventory_sql_dataadapter = new SqlDataAdapter();
            inventory_sql_dataadapter.InsertCommand = inventory_sql_command;
            inventory_sql_command.ExecuteNonQuery();
        }

        public void inventory_sqladapterDelete() //public function codes for mediating between C# language and the MSSQL DELETE command
        {
            inventory_sql_dataadapter = new SqlDataAdapter();
            inventory_sql_dataadapter.DeleteCommand = inventory_sql_command;
            inventory_sql_command.ExecuteNonQuery();
        }

        public void inventory_sqladapterUpdate() //public function codes for mediating between C# language and the MSSQL UPDATE command
        {
            inventory_sql_dataadapter = new SqlDataAdapter();
            inventory_sql_dataadapter.UpdateCommand = inventory_sql_command;
            inventory_sql_command.ExecuteNonQuery();
        }

        public void inventory_sqldatasetSELECT() //codes for mirroring the contents of the database inside MSSQL to C# or Visual Studio
        {
            inventory_sql_dataset = new DataSet();
            inventory_sql_dataadapter.Fill(inventory_sql_dataset, "Product");
        }
    }

}
