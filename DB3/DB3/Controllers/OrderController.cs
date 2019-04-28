using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB3.Models;

namespace DB3.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            DB3Entities1 db = new DB3Entities1();
            List<Order> o = new List<Order>();
            List<OrderViewModel> ol = new List<OrderViewModel>();
            OrderViewModel oi = new OrderViewModel();
            foreach(Order s in o)
            {
                oi.Medicine_Name = s.Medicine_Name;
                oi.Quantity = s.Quantity;
                oi.Price = s.Price;
                oi.medicine_id = s.medicine_id;
                ol.Add(oi);
            }
            return View(ol);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(OrderViewModel s)
        {
            try
            {
                DB3Entities1 db = new DB3Entities1();
                Order o = new Order();
                o.Medicine_Name = s.Medicine_Name;
                o.Quantity = s.Quantity;
                o.Price = s.Price;
                o.medicine_id = s.medicine_id;
                db.Orders.Add(o);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            DB3Entities1 db = new DB3Entities1();
            List<Order> c = db.Orders.ToList();
           OrderViewModel cs = new OrderViewModel();
            foreach (Order s in c)
            {
                if (id == s.order_id)
                {
                    cs.Medicine_Name = s.Medicine_Name;
                    cs.Quantity = s.Quantity;
                    cs.Price = s.Price;
                    
                    cs.medicine_id = s.medicine_id;
                }

            }
            return View(cs);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(OrderViewModel s,int iD = 0)
        {
            try
            {
                DB3Entities1 db = new DB3Entities1();
                List<Order> c = db.Orders.ToList();
                foreach (Order cs in c)
                {
                    if (iD == cs.order_id)
                    {
                        s.Medicine_Name = cs.Medicine_Name;
                        s.Quantity = cs.Quantity;
                        s.Price = cs.Price;
                        
                        s.medicine_id = cs.medicine_id;
                        db.SaveChanges();
                    }

                }
                // TODO: Add update logic here

                return RedirectToAction("Index", new { id = iD });
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
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
