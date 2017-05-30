using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.BusinessService
{
    public interface IDepartmentService
    {
        List<Department> GetAllDepartment();

        string GetDapartmentById(int id);

        bool AddDepartment(Department department);

        bool DeleteDepartment(int id);

        bool UpdateDepartment(Department department);


    }

}
