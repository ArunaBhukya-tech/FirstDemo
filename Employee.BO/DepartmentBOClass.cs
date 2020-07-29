using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDB;

namespace EmployeeBO
{
  public  class DepartmentBOClass
    {
        DepartmentDBClass objDepartmentdb = new DepartmentDBClass();
        public IEnumerable<Department> GetDepartments()
        {
            return objDepartmentdb.GetDepartments();
        }
        public void Insert(Department ObjDept)
        {
            objDepartmentdb.InsertDepartment(ObjDept);
        }
        public void Edit(Department objDept)
        {
            objDepartmentdb.EditDepartment(objDept);
        }
        public void Delete(int Id)
        {
            objDepartmentdb.DeleteDepartment(Id);
        }
    }
}
