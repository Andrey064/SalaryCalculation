using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.Sql
{
    public static class Scripts
    {
        /// <summary>
        /// sql to insert a person
        /// </summary>
        public static readonly string SqlInsertPerson = "Insert Into" +
            " Person(Name, Surname, Patronymic, SalaryBase, SalaryDop, Bonus, SalaryFull, DepartmentID)" +
            " Values(@Name, @Surname, @Patronymic, @SalaryBase, @SalaryDop, @Bonus, @SalaryFull, @DepartmentID)";

        /// <summary>
        /// sql get all persons
        /// </summary>
        public static readonly string SqlGetAllPersons = "Select " +
            " PersonID, Name, Surname, Patronymic, DepartmentID, SalaryBase, SalaryDop, Bonus, SalaryFull" +
            " From Person";

        /// <summary>
        /// Sql to get a person by Id
        /// </summary>
        public static readonly string SqlGetPersonById = "Select" +
            " PersonID, Name, Surname, Patronymic, SalaryBase, SalaryDop, Bonus, DepartmentID" +
            " From Person Where PersonID = @Id";

        /// <summary>
        /// Sql update a person by Id
        /// </summary>
        public static readonly string SqlUpdatePerson = "Update Person" +
            " Set Name=@Name, Surname=@Surname, Patronymic=@Patronymic," +
            " SalaryBase=@SalaryBase, SalaryDop=@SalaryDop, Bonus=@Bonus, SalaryFull=@SalaryFull, DepartmentID=@DepartmentID" +
            " Where PersonID = @Id";

        /// <summary>
        /// Sql delete a person by Id
        /// </summary>
        public static readonly string SqlDeletePerson = "Delete * From Person Where PersonID = @Id";

        /// <summary>
        /// Sql select Persons by DepartmentId
        /// </summary>
        public static readonly string SqlGetPersonsByDepartmentId = "Select PersonID, Name, Surname, Patronymic, DepartmentID, SalaryBase, SalaryDop, Bonus, SalaryFull" +
            " From Person Where DepartmentID=@DepartmentID";

        /// <summary>
        /// sql to search for persons
        /// </summary>
        public static readonly string SqlSearchPersonsDepId = "Select" +
            " PersonID, Name, Surname, Patronymic,  DepartmentID, SalaryBase, SalaryDop, Bonus, SalaryFull" +
            " From Person Where (DepartmentID=@DepartmentID)";

        public static readonly string SqlSearchPersonsSurName = "Select" +
            " PersonID, Name, Surname, Patronymic,  DepartmentID, SalaryBase, SalaryDop, Bonus, SalaryFull" +
            " From Person Where (Surname Like @Surname)";

        public static readonly string SqlSearchPersons = "Select" +
            " PersonID, Name, Surname, Patronymic,  DepartmentID, SalaryBase, SalaryDop, Bonus, SalaryFull" +
            " From Person Where (DepartmentID=@DepartmentID) and (Surname Like @Surname)";


        public static readonly string SqlUpdateBonus = "Update Person" +
            " Set Bonus=@Bonus, SalaryFull=(SalaryBase+SalaryDop)+(SalaryBase+SalaryDop)*@Bonus/100 Where DepartmentID=@DepartmentID";
    }
}
