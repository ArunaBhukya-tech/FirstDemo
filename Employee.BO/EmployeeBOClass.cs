using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDB;

namespace EmployeeBO
{
  public  class EmployeeBOClass
    {
        EmployeeDBClass objemployeedb = new EmployeeDBClass();

        public Employee GetById(int Id)
        {
            return objemployeedb.GetById(Id);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return objemployeedb.GetEmployees();
        }
        public void Insert(Employee objemp)
        {
            objemployeedb.InsertEmployee(objemp);
        }
        public void Edit(Employee objemp)
        {
            objemployeedb.EditEmployee(objemp);
        }
        public void Delete(int Id)
        {
            objemployeedb.DeleteEmployee(Id);
        }
       
    }
}
