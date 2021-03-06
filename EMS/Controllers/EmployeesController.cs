﻿using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EMS.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            var employees = await DocumentDBRepo<Employee>.GetItemsAsync(e => e.FirstName!="");
            return View(employees);
        }


        // GET: Employees/Details/5
        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id)
        {

            Employee emp = await DocumentDBRepo<Employee>.GetIEmpAsync(id);
            return View(emp);
            
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        //[HttpPost]
        //[ActionName("Create")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> CreateAsync([Bind(Include = "Id,Name,Description,Completed")] Item item)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await DocumentDBRepo<Employee>.CreateItemAsync(item);
        //        return RedirectToAction("Index");
        //    }

        //    return View(item);
        //}

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
