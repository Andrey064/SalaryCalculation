using Salary.Model.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Salary.Model.BusinessService
{
    public class PersonService : IPersonService
    {
        private ISalaryAccess personAccess;
        public PersonService()
        {
            personAccess = new SalaryAccess();
        }


        public bool DeletePerson(int id)
        {
            return personAccess.DeletePerson(id);
        }

        public DataTable GetAllPersons()
        {
            return personAccess.GetAllPersons();
        }

        public DataRow GetPersonById(int id)
        {
            return personAccess.GetPersonById(id);
        }

        public DataTable GetPersonsByDepartmentId(int id)
        {
            return personAccess.GetPersonsByDepartmentId(id);
        }

        public bool RegisterPerson(Person person)
        {
            return personAccess.AddPerson(person);
        }

        public DataTable SearchPersons(int department, string surname)
        {
            return personAccess.SearchPersons(department, surname);
        }

        public bool UpdateBonusByDepartmentId(decimal bonus, int id)
        {
            return personAccess.UpdateBonusByDepartmentID(bonus, id);
        }

        public bool UpdatePerson(Person person)
        {
            return personAccess.UpdatePerson(person);
        }
        
    }
}
