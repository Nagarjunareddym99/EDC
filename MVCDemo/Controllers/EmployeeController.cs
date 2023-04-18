using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
           List<Employee> employee = employeeContext.Employees.ToList();

            return View(employee);
        }
    
        public ActionResult GetDetails(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee emp =  employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            
            return View(emp);
        }
    }
}
