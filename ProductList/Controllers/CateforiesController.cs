using ProductList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductList.Controllers
{
    public class CateforiesController : Controller
    {
        // GET: Catefories
        public ActionResult Index()
        {
            List<Category> cat = new List<Category>()
            {
                new Category() { CategoryId = 101, CategoryName = "Food" },
                new Category() { CategoryId = 102, CategoryName = "Equipment"},
               
            };
            ViewBag.cat = cat;
            return View();
        }
    }
}