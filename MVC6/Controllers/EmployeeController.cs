using MVC6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6.Controllers
{
    public class EmployeeController : Controller
    {
		// GET: Employee
		public ActionResult Details(int id)
		{
			SampleDbContext db = new SampleDbContext();
			EmployeeData employees = db.EmployeeDatas.Single(x => x.Id == id);
			return View(employees);
		}

		public ActionResult SecondDetails(int id)
		{
			SampleDbContext db = new SampleDbContext();
			EmployeeData employees = db.EmployeeDatas.Single(x => x.Id == id);
			ViewData["EmployeeData"] = employees;
			return View();
		}
		public ActionResult Edit(int id)
		{
			SampleDbContext db = new SampleDbContext();
			EmployeeData employees = db.EmployeeDatas.Single(x => x.Id == id);
			return View(employees);
		}
	}
}