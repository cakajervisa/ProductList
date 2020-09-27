﻿using ProductList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductList.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { ProductId = 101, ProductName = "AC", Rate = 45000 },
                new Product() { ProductId = 102, ProductName = "Mobile", Rate = 38000 },
                new Product() { ProductId = 103, ProductName = "Bike", Rate = 94000 }
            };
            ViewBag.products = products;
            return View();
        }
        public ActionResult Details(int id)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { ProductId = 101, ProductName = "AC", Rate = 45000 },
                new Product() { ProductId = 102, ProductName = "Mobile", Rate = 38000 },
                new Product() { ProductId = 103, ProductName = "Bike", Rate = 94000 }
            };
            Product matchingProduct = null;
            foreach (var item in products)
            {
                if (item.ProductId == id)
                {
                    matchingProduct = item;
                }
            }
            ViewBag.MatchingProduct = matchingProduct;
            return View();
        }
    }
}