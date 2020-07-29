using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeBO;
using EmployeeDB;
namespace EmployeeWEB.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBOClass  ObjEmpBO = new EmployeeBOClass();
        DepartmentBOClass objdeptBO = new DepartmentBOClass();
        // GET: Employee
        public ActionResult Index()
        {
            return View(ObjEmpBO.GetEmployees());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Department = new SelectList(objdeptBO.GetDepartments(), "PKDeptId", "DeptName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee objemp)
        {
            ViewBag.Department = new SelectList(objdeptBO.GetDepartments(), "PKDeptId", "DeptName");
            ObjEmpBO.Insert(objemp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Department = new SelectList(objdeptBO.GetDepartments(), "PKDeptId", "DeptName");
            Employee objemployee = ObjEmpBO.GetById(id);
            return View(objemployee);
        }
        [HttpPost]
        public ActionResult Edit(Employee objemp)
        {
            ViewBag.Department = new SelectList(objdeptBO.GetDepartments(), "PKDeptId", "DeptName");
            ObjEmpBO.Edit(objemp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            Employee objemp = ObjEmpBO.GetById(Id);
            return View(objemp);

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int Id)
        {

            ObjEmpBO.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}