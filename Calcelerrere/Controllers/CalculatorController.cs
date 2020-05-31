using Calcelerrere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calcelerrere.Controllers
{
    public class CalculatorController : Controller
    {

        // GET: Calculator/
        public ActionResult Index()
        {
            return View(new Calculate());
        }
        [HttpPost]
        public ActionResult Index(Calculate c,int FN,int SN, string calculate)
        {
            int total = 0;
            if (calculate == "add")
            {
                total = FN + SN;
            }
            else if (calculate == "sub")
            {
              //  c.result = c.summ - c.time;
            }
            else if (calculate == "mul")
            {
              //  c.result = c.summ * c.time;
            }
            else
            {
               // c.result = c.summ / c.time;
            }
            c.result = total;
            
            return View(c);
        }
    }
}