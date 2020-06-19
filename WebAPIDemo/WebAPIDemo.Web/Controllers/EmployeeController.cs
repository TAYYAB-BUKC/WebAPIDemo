using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPIDemo.Web.Models;

namespace WebAPIDemo.Web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees;
            HttpResponseMessage response = HttpConfiguration.httpClient.GetAsync("Employee").Result;
            employees = response.Content.ReadAsAsync<List<Employee>>().Result;

            return View(employees);
        }

        public ActionResult AddorEditEmployee(int id = 0)
		{
			if (id == 0)
			{
                return View(new Employee());
            }
			else
			{
                HttpResponseMessage response = HttpConfiguration.httpClient.GetAsync("Employee/"+id.ToString()).Result;
             
                return View(response.Content.ReadAsAsync<Employee>().Result);
			}
        }

        [HttpPost]
        public ActionResult AddorEditEmployee(Employee employee)
        {
			if (employee.EmployeeID == 0)
			{
                HttpResponseMessage response = HttpConfiguration.httpClient.PostAsJsonAsync("Employee", employee).Result;
                TempData["message"] = "Employee Added Successfully";
            }
			else
			{
                HttpResponseMessage response = HttpConfiguration.httpClient.PutAsJsonAsync("Employee/"+ employee.EmployeeID,employee).Result;
                TempData["message"] = "Employee Updated Successfully";
            }
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEmployee(int id)
		{
            return RedirectToAction("Index");
        }
    }
}