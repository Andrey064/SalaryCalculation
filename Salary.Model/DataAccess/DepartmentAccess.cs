using Salary.Model.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.DataAccess
{
    public class DepartmentAccess : ConnectionAccess, IDepartmentAccess
    {
        public bool AddDepartment(Department department)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                oleDbCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbCommand.CommandType = System.Data.CommandType.Text;
                oleDbCommand.CommandText = ScriptsDepartment.SqlAddDepartment;

                oleDbCommand.Parameters.AddWithValue("@DepartmentID", department.DepartmentID);
                oleDbCommand.Parameters.AddWithValue("@DepName", department.DepName);

                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool DeleteDepartment(int id)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                oleDbCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = ScriptsDepartment.SqlDeleteDepartment;

                oleDbCommand.Parameters.AddWithValue("@DepartmentID", id);

                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public List<Department> GetAllDepartment()
        {
            List<Department> departmentList = new List<Department>();

            using (OleDbConnection oleDbConnection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand oleDbCommand = new OleDbCommand(ScriptsDepartment.SqlGetAllDepartments, oleDbConnection);

                oleDbConnection.Open();

                OleDbDataReader reader = oleDbCommand.ExecuteReader();
                departmentList.Add(new Department() { DepartmentID=0, DepName="" });
                while (reader.Read())
                {
                    Department department = new Department();

                    department.DepartmentID = Convert.ToInt32(reader["DepartmentID"]);
                    department.DepName = reader["DepName"].ToString();

                    departmentList.Add(department);
                }
            }
            return departmentList;

        }

        public string GetDepartmentById(int id)
        {
            string departmentName = "";

            using (OleDbConnection oleDbConnection = new OleDbConnection(ConnectionString))
            {
                OleDbCommand oleDbCommand = new OleDbCommand(ScriptsDepartment.SqlSelectDepartmentById, oleDbConnection);

                oleDbCommand.Parameters.AddWithValue("@DepartmentID", id);

                oleDbConnection.Open();

                OleDbDataReader reader = oleDbCommand.ExecuteReader();
                while (reader.Read())
                {
                    departmentName = reader["DepName"].ToString();
                }
            }
            return departmentName;
        }

        public bool UpdateDepartment(Department department)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                oleDbCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = ScriptsDepartment.SqlUpdateDepartment;

                oleDbCommand.Parameters.AddWithValue("@DepartmentID", department.DepartmentID);
                oleDbCommand.Parameters.AddWithValue("@DepName", department.DepName);

                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }

        }
    }
}
