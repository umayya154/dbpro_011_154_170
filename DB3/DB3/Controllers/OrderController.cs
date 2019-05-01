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
            List<Order> o = db.Orders.ToList();
            List<OrderViewModel> ol = new List<OrderViewModel>();
            //OrderViewModel oi = new OrderViewModel();
            foreach(Order s in o)
            {
                OrderViewModel oi = new OrderViewModel();
                oi.order_id = s.order_id;
               // oi.Medicine_Name = s.Medicine_Name;
                oi.Quantity = s.Quantity;
                oi.Price = s.Price;
                Medicine c = db.Medicines.Where(x => x.Medicine_id == s.medicine_id).First();
                oi.Medicine_Name = s.Medicine_Name;
                //oi.medicine_id = s.medicine_id;
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
               // Order o = new Order();
                var order = new Order();
                order.Medicine_Name = s.Medicine_Name;
                order.Quantity = s.Quantity;
                order.Price = s.Price;
                var c = db.Medicines.Where(x => x.Medicine_Name == s.Medicine_Name).First();
                order.medicine_id = c.Medicine_id;
                //var d = db.Medicines.Where(x => x.Medicine_id == s.medicine_id).First();
               
                db.Orders.Add(order);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            DB3Entities1 db = new DB3Entities1();
            
            var s = db.Orders.Where(x => x.order_id == id).First();
            //List<Order> c = db.Orders.ToList();
           OrderViewModel cs = new OrderViewModel();
           
                    cs.Medicine_Name = s.Medicine_Name;
                    cs.Quantity = s.Quantity;
                    cs.Price = s.Price;
            var g = db.Medicines.Where(x => x.Medicine_id == s.medicine_id).First();
            cs.type = g.Type;    
                    //cs.medicine_id = s.medicine_id;
                
            return View(cs);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(OrderViewModel s,int id)
        {
            try
            {
                DB3Entities1 db = new DB3Entities1();
                
                var cs = db.Orders.Where(x => x.order_id == id).First();
                List<Order> c = db.Orders.ToList();
                
                        s.Medicine_Name = cs.Medicine_Name;
                        s.Quantity = cs.Quantity;
                        s.Price = cs.Price;
                // var g = db.Medicines.Where()
                        s.medicine_id = cs.medicine_id;
                        db.SaveChanges();
                    
                // TODO: Add update logic here

                return RedirectToAction("Index", new { id =cs.medicine_id });
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
