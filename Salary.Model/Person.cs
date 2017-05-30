using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public decimal SalaryBase { get; set; }
        public decimal SalaryDop { get; set; }
        public decimal Bonus { get; set; }
        public decimal SalaryFull { get { return (SalaryBase + SalaryDop) + (SalaryBase + SalaryDop)*Bonus/100; } }
        public Department DepartmentID { get; set; }
    }
}
