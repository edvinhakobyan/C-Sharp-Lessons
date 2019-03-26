using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Razor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Razor.Controllers
{
    public class HomeControllers:Controller
    {
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "А boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            return View(myProduct);
        }      
    }
}