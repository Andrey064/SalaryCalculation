using Salary.Model.Sql;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace Salary.Model.DataAccess
{
    public class SalaryAccess : ConnectionAccess, ISalaryAccess
    {
        public bool AddPerson(Person person)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                oleDbCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbCommand.CommandType = System.Data.CommandType.Text;
                oleDbCommand.CommandText = Scripts.SqlInsertPerson;

                // Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@Name", person.Name);
                oleDbCommand.Parameters.AddWithValue("@Surname", person.Surname);
                oleDbCommand.Parameters.AddWithValue("@Patronymic", person.Patronymic);

                oleDbCommand.Parameters.Add("@SalaryBase", OleDbType.Double);
                oleDbCommand.Parameters["@SalaryBase"].Value = person.SalaryBase;

                oleDbCommand.Parameters.Add("@SalaryDop", OleDbType.Double);
                oleDbCommand.Parameters["@SalaryDop"].Value = person.SalaryDop;

                oleDbCommand.Parameters.Add("@Bonus", OleDbType.Double);
                oleDbCommand.Parameters["@Bonus"].Value=person.Bonus;

                oleDbCommand.Parameters.Add("@SalaryFull", OleDbType.Double);
                oleDbCommand.Parameters["@SalaryFull"].Value = person.SalaryFull;

                oleDbCommand.Parameters.AddWithValue("@DepartmentID", person.DepartmentID.DepartmentID);

                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool DeletePerson(int id)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                oleDbCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = Scripts.SqlDeletePerson;

                oleDbCommand.Parameters.AddWithValue("@Id", id);

                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public DataTable GetAllPersons()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlGetAllPersons;

                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataRow GetPersonById(int id)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(ConnectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = Scripts.SqlGetPersonById;

                dataAdapter.SelectCommand.Parameters.AddWithValue("@Id", id);

                dataAdapter.Fill(dataTable);

                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }

        public DataTable GetPersonsByDepartmentId(int id)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlGetPersonsByDepartmentId;
                oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@DepartmentID", id);
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable SearchPersons(int department, string surname)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                //oleDbDataAdapter.SelectCommand.CommandText = string.Format(Scripts.SqlSearchPersons, operand);
                //oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlSearchPersons;

                if (department==0)
                {
                    oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlSearchPersonsSurName;
                    oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@Surname", "%" + surname + "%");
                }
                else if ((surname==null) || (surname == ""))
                {
                    oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlSearchPersonsDepId;
                    oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@DepartmentID", department);
                }
                else if ((surname!="") && (department!=0))
                {
                    oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlSearchPersons;
                    oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@DepartmentID", department);
                    oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@Surname", "%" + surname + "%");
                }

                // Add the input parameters to the parameter collection
                
                // Fill the table from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public bool UpdateBonusByDepartmentID(decimal bonus, int id)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                oleDbCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = Scripts.SqlUpdateBonus;

                oleDbCommand.Parameters.AddWithValue("@Bonus", bonus);
                oleDbCommand.Parameters.AddWithValue("DepartmentID", id);

                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool UpdatePerson(Person person)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                oleDbCommand.Connection = new OleDbConnection(ConnectionString);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = Scripts.SqlUpdatePerson;

                oleDbCommand.Parameters.AddWithValue("@Name", person.Name);
                oleDbCommand.Parameters.AddWithValue("@Surname", person.Surname);
                oleDbCommand.Parameters.AddWithValue("@Patronymic", person.Patronymic);

                oleDbCommand.Parameters.Add("@SalaryBase", OleDbType.Double);
                oleDbCommand.Parameters["@SalaryBase"].Value = person.SalaryBase;

                oleDbCommand.Parameters.Add("@SalaryDop", OleDbType.Double);
                oleDbCommand.Parameters["@SalaryDop"].Value = person.SalaryDop;

                oleDbCommand.Parameters.Add("@Bonus", OleDbType.Double);
                oleDbCommand.Parameters["@Bonus"].Value = person.Bonus;

                oleDbCommand.Parameters.Add("@SalaryFull", OleDbType.Double);
                oleDbCommand.Parameters["@SalaryFull"].Value = person.SalaryFull;

                oleDbCommand.Parameters.AddWithValue("@DepartmentID", person.DepartmentID.DepartmentID);

                oleDbCommand.Parameters.AddWithValue("@Id", person.PersonID);

                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
