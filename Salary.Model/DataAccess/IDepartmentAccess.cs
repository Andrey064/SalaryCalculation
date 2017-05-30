using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.DataAccess
{
    public interface IDepartmentAccess
    {
        string GetDepartmentById(int id);

        List<Department> GetAllDepartment();

        bool AddDepartment(Department department);

        bool UpdateDepartment(Department department);

        bool DeleteDepartment(int id);
    }
}
