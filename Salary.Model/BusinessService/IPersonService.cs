using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.BusinessService
{
    public interface IPersonService
    {
        /// <summary>
        /// Person registration
        /// </summary>
        /// <param name="person">person model</param>
        /// <returns>true or false</returns>
        bool RegisterPerson(Person person);

        /// <summary>
        /// Service method to get all persons
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetAllPersons();

        /// <summary>
        /// Return person by id
        /// </summary>
        /// <returns>Data table</returns>
        DataRow GetPersonById(int id);

        /// <summary>
        /// Person update
        /// </summary>
        /// <param name="person">person model</param>
        /// <returns>true or false</returns>
        bool UpdatePerson(Person person);

        bool DeletePerson(int id);

        /// <summary>
        /// Service method to get all persons by DepartmentId
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetPersonsByDepartmentId(int id);

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="department">department value</param>
        /// <param name="surname">surname</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        DataTable SearchPersons(int department, string surname);

        bool UpdateBonusByDepartmentId(decimal bonus, int id);

    }
}
