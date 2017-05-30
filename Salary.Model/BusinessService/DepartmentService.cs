using Salary.Model.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Model.BusinessService
{
    public class DepartmentService : IDepartmentService
    {
        private IDepartmentAccess departmentAccess;
        public DepartmentService()
        {
            departmentAccess = new DepartmentAccess();
        }

        public bool AddDepartment(Department department)
        {
            return departmentAccess.AddDepartment(department);
        }

        public bool DeleteDepartment(int id)
        {
            return departmentAccess.DeleteDepartment(id);
        }

        public List<Department> GetAllDepartment()
        {
            return departmentAccess.GetAllDepartment();
        }

        public string GetDapartmentById(int id)
        {
            return departmentAccess.GetDepartmentById(id);
        }

        public bool UpdateDepartment(Department department)
        {
            return departmentAccess.UpdateDepartment(department);
        }
    }
}
