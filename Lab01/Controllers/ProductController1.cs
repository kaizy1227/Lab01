using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    public class ProductController1 : Controller
    {
        private static List<Product> Products = new
            List<Product>();
        public IActionResult Index()
        {
            return View(Products);
        }
    }
}
