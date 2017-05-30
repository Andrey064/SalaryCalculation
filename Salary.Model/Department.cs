using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepName { get; set; }

        public override string ToString()
        {
            return DepName;
        }
    }
}
