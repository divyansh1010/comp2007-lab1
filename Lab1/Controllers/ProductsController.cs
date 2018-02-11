using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        //GET: Products/Details/[cat]

        public ActionResult Details(string cat)
        {
            if (cat == null)
            {
   
                return View("Index");
            }
            ViewBag.Youselectedproduct = cat;

            return View();

        }
    }
}