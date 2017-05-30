using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Data
{
    public class SalaryDB
    {
        public DataTable GetPerson()
        {
            string conStr = Properties.Settings.Default.SalaryDBConnectionString;

            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand cmd = new OleDbCommand("select * from Person", con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Persons");
            return ds.Tables["Persons"];
        }

        
    }
}
