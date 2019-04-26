using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB3.Models;

namespace DB3.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            DB3Entities db = new DB3Entities();
            List<Customer> cs = db.Customers.ToList();
            List<CustomerViewModel> csv = new List<CustomerViewModel>();
            CustomerViewModel c = new CustomerViewModel();
            foreach (Customer s in cs)
            {


                c.Name = s.Name;
                c.Address = s.Address;
                c.Phone = s.Phone;
                //c.status = Convert.ToInt32(s.status);
                c.city = s.city;

                csv.Add(c);
            }
                return View(c);
        }

        // GET: Customer/Details/5
        public ActionResult CustomerDetails(int id)
        {
            DB3Entities db = new DB3Entities();
            List<Customer> cs = db.Customers.ToList();
            //userid = id;
            CustomerViewModel c = new CustomerViewModel();
            foreach (Customer s in cs)
            {
                if (s.user_id == id)
                {

                    c.Name = s.Name;
                    c.Address = s.Address;
                    c.Phone = s.Phone;
                    // c.status = Convert.ToInt32(s.status);
                    c.city = s.city;


                }
            }
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerViewModel s)
        {
            try
            {
                DB3Entities db = new DB3Entities();
                Customer c = new Customer();
                c.Name = s.Name;
                c.Address = s.Address;
                c.Phone = s.Phone;
                //c.status = s.status;
                c.city = s.city;
                db.Customers.Add(c);
                db.SaveChanges();

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id = 0)
        {
            DB3Entities db = new DB3Entities();
            List<Customer> c = db.Customers.ToList();
            CustomerViewModel cs = new CustomerViewModel();
            foreach (Customer s in c)
            {
                if (id == s.user_id)
                {
                    cs.Name = s.Name;
                    cs.Address = s.Address;
                    cs.Phone = s.Phone;
                    cs.city = s.city;
                }

            }
            return View(c);
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
                DB3Entities db = new DB3Entities();
                List<Customer> c = db.Customers.ToList();
                var del = db.Customers.Where(x => x.user_id == id).First();
                db.Customers.Remove(del);
                db.SaveChanges();
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
