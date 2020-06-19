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
    }
}