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
           string nagarjuna="nagarjuna";
            EmployeeContext employeeContext = new EmployeeContext();
           List<Employee> emp = employeeContext.Employees.ToList();

            return View(emp);
        }
    
        public ActionResult GetDetails(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee =  employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            
            return View(employee);
        }
    }
}
