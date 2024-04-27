using Ibiza_Pizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ibiza_Pizza.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Veg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Veg(Ibiza IP)
        {
            IP.Total = IP.calcTotal();
            IP.Change = IP.calcChange();
            IP.name = IP.name;
            return View(IP);
        }
    }
}