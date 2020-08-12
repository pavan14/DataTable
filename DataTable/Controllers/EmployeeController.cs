﻿using DataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTable.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
            {
              using(DBModel db= new DBModel())
                {
                List<Employee> empList=db.Employees.ToList<Employee>();
                return Json(new{data=empList},JsonRequestBehavior.AllowGet);
                 }
             }
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            return View(new Employee());

        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}