using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contramcamlamroi.Models;

namespace Contramcamlamroi.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private DBSportStoreEntities2 db = new DBSportStoreEntities2();
        public ActionResult Index(string _name)
        {
            if (_name == null)
                return View(db.OrderPro.ToList());
            else
                return View(db.OrderPro.Where(s => s.NameCus.Contains(_name)).ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            try
            {
                db.OrderPro.Add(cus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Error Craete New");
            }
        }
    }
}