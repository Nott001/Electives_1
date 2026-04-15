using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Biometrics
{
    internal class employee_attendanceDB_connection
    {
        public String attendance_connectionString = null;
        public SqlConnection attendance_sql_connection;
        public SqlCommand attendance_sql_command;
        public DataSet attendance_sql_dataset;
        public SqlDataAdapter attendance_sql_dataadapter;
        public string attendance_sql = null;

        public void attendance_connString()
        {
            attendance_sql_connection = new SqlConnection();
            attendance_connectionString = "Server=Nott\\SQLEXPRESS;Database=Employee_Biometrics;Trusted_Connection=True;";

            attendance_sql_connection = new SqlConnection(attendance_connectionString);
            attendance_sql_connection.ConnectionString = attendance_connectionString;
            attendance_sql_connection.Open();
        }

        public void attendance_cmd()
        {
            attendance_sql_command = new SqlCommand(attendance_sql, attendance_sql_connection);
            attendance_sql_command.CommandType = CommandType.Text;
        }

        public void attendance_sqldataadapterSelect()
        {
            attendance_sql_dataadapter = new SqlDataAdapter();
            attendance_sql_dataadapter.SelectCommand = attendance_sql_command;
            attendance_sql_command.ExecuteNonQuery();
        }

        public void attendance_sqldataadapterInsert()
        {
            attendance_sql_dataadapter = new SqlDataAdapter();
            attendance_sql_dataadapter.InsertCommand = attendance_sql_command;
            attendance_sql_command.ExecuteNonQuery();
        }

        public void attendance_sqldataadapterDelete()
        {
            attendance_sql_dataadapter = new SqlDataAdapter();
            attendance_sql_dataadapter.DeleteCommand = attendance_sql_command;
            attendance_sql_command.ExecuteNonQuery();
        }

        public void attendance_sqldataadapterUpdate()
        {
            attendance_sql_dataadapter = new SqlDataAdapter();
            attendance_sql_dataadapter.UpdateCommand = attendance_sql_command;
            attendance_sql_command.ExecuteNonQuery();
        }

        public void attendance_sqldatasetSELECT()
        {
            attendance_sql_dataset = new DataSet();
            attendance_sql_dataadapter.Fill(attendance_sql_dataset, "attendanceTbl"); // change to your actual table name
        }

    }
}
