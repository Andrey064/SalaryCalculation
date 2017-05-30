using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.Sql
{
    public static class ScriptsDepartment
    {
        public static readonly string SqlGetAllDepartments = "Select DepartmentID," +
            " DepName From Department";

        public static readonly string SqlAddDepartment = "Insert Into" +
            " Department(DepartmentID, DepName)" +
            " Values(@DepartmentID, @DepName)";

        public static readonly string SqlDeleteDepartment = "Delete * From Department" +
            " Where DepartmentID=@Id";

        public static readonly string SqlUpdateDepartment = "Update Department" +
            " Set DepartmentID=@DepartmentID, DepName=@DepName Where DepartmentID=@DepartmentID";

        public static readonly string SqlSelectDepartmentById = "Select DepName" +
            " From Department Where DepartmentID=@DepartmentID";



    }
}
