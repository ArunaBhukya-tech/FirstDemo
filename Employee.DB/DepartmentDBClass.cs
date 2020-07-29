
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
   public class DepartmentDBClass
    {
        EmployeeDBEntities dbContext = new EmployeeDBEntities();
        public IEnumerable<Department> GetDepartments()
        {
            return dbContext.Departments.ToList();
        }

        public void InsertDepartment(Department objDepartment)
        {
            dbContext.Departments.Add(objDepartment);
            dbContext.SaveChanges();
        }
        public void EditDepartment(Department objDepartment)
        {
            dbContext.Entry(objDepartment).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteDepartment(int DeptId)
        {
            Department objDept = dbContext.Departments.Find(DeptId);
            dbContext.Departments.Remove(objDept);
            dbContext.SaveChanges();
        }
    }
}
