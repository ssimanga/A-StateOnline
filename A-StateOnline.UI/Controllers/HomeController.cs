﻿using A_StateOnline.Core.Contracts;
using A_StateOnline.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_StateOnline.UI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Product> context;
        IRepository<ProductCategory> productCategories;
        public HomeController(IRepository<Product> productContext, IRepository<ProductCategory> categoryContext)
        {
            context = productContext;
            productCategories = categoryContext;
        }
        public ActionResult Index()
        {
            List<Product> products = context.Collection().ToList();
            return View(products);
        }
        public ActionResult Details(string Id)
        {
            Product product = context.Find(Id);
            if(product == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(product);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}