using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC6.Models;

namespace MVC6.Controllers
{
    public class HomeController : Controller
    {
 
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
			SampleDbContext db = new SampleDbContext();
			EmployeeData employees = db.EmployeeDatas.Single(x => x.Id == id);
            return View(employees);
        }


		public ActionResult Edit(int id)
		{
			SampleDbContext db = new SampleDbContext();
			EmployeeData employees = db.EmployeeDatas.Single(x => x.Id == id);
			return View(employees);
		}
		[HttpPost]
		public ActionResult Edit(Employee employee)
		{
			if (ModelState.IsValid)
			{
				SampleDbContext db = new SampleDbContext();
				EmployeeData employeeFromDB = db.EmployeeDatas.Single(x => x.Id == employee.Id);

				employeeFromDB.FullName = employee.FullName;
				employeeFromDB.Gender = employee.Gender;
				employeeFromDB.Age = employee.Age;
				employeeFromDB.HireDate = employee.HireDate;
				employeeFromDB.Salary = employee.Salary;
				employeeFromDB.PersonalWebsite = employee.PersonalWebsite;

			
				db.Entry(employeeFromDB).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Details", new { id = employee.Id });
			}
			return View(employee);
		}
		// GET: Home/Create
		public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
      
    }
}
