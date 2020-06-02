using Calcelerrere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data.Entity;

namespace Calcelerrere.Controllers
{
    public class CalculatorController : Controller
    {
        double total;
        int n;
        double summ;


        // GET: Calculator/

        public ActionResult Index()
        {
            return View(new Calculate());
        }

        [HttpPost]
        public ActionResult Index(Calculate c, int FN, int SN, double TN, string calculate)
        {
            using (ResultContext db = new ResultContext())
            {
                if (calculate == "add")
                {
                    double i = (double)TN / 12 / 100;
                    n = SN;
                    double k = (i * Math.Pow(1 + i, n)) / (Math.Pow(1 + i, n) - 1);
                    summ = (double)FN * k;
                    total = summ;

                    DateTime date = DateTime.Now;
                    int id = 1;
                    double AmountBody = total;
                    double AmountPrecent = (double)FN / n;
                    double remain = FN;


                    for (int l = 0; l < n; l++)
                    {
                        Result p = new Result { id = id, date = date, AmountBody = AmountBody, AmountPercent = AmountPrecent, Remain = remain };
                        id++;
                        date = date.AddDays(30);
                        remain = remain - total;
                        db.Results.Add(p);
                        db.SaveChanges();
                    }

                    c.result = total;
                }
                return View(c);

            }
        }

        public JsonResult GetTable()
        {
            using (ResultContext db = new ResultContext())
            {
                var resultats = db.Results.ToList();

                var jsonData = new
                {
                    rows = resultats
                };

                return Json(jsonData, JsonRequestBehavior.AllowGet);
            }

        }
    }
}
       
 