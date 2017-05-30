using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.DataAccess
{
    public interface ISalaryAccess
    {
        bool AddPerson(Person person);

        DataTable GetAllPersons();

        DataRow GetPersonById(int id);

        bool UpdatePerson(Person person);

        bool DeletePerson(int id);

        DataTable GetPersonsByDepartmentId(int id);

        DataTable SearchPersons(int department, string surname);

        bool UpdateBonusByDepartmentID(decimal bonus, int id);
    }

}
