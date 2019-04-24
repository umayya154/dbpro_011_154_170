using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBLabProject.Models;

namespace DBLabProject.Controllers
{
    public class CustomerController : Controller
    {
        DB3Entities db = new DB3Entities();
        // GET: Customer
        public ActionResult Index()
        {
           // Model1 db = new Model1();
           
            
                return View();
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
        List<Customer> cs = db.Customers.ToList();
        List<CustomerViewModel> csv = new List<CustomerViewModel>();
            foreach (Customer s in cs)
            {
                CustomerViewModel c = new CustomerViewModel();
                c.user_Id = s.user_id;
                c.Name = s.Name;
                c.Address = s.Address;
                c.Phone = s.Phone;
                c.status = Convert.ToInt32(s.status);
                c.city = s.city;
                c.order_Id = Convert.ToInt32(s.order_id);
                csv.Add(c);
            }


            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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
