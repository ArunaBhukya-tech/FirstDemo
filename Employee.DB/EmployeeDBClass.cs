using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
  public  class EmployeeDBClass
    {
        EmployeeDBEntities dbContext = new EmployeeDBEntities();

        public Employee GetById(int Id)
        {
            return dbContext.Employees.Find(Id);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }
         
        public void InsertEmployee(Employee objemployee)
        {
            dbContext.Employees.Add(objemployee);
            dbContext.SaveChanges();
        }
        public void EditEmployee(Employee objemployee)
        {
            dbContext.Entry(objemployee).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteEmployee(int EmpId)
        {
            Employee objemp = dbContext.Employees.Find(EmpId);
            dbContext.Employees.Remove(objemp);
            dbContext.SaveChanges();
        }

    }
}
