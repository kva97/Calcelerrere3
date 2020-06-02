using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Calcelerrere.Models
{
    public class Result
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public double AmountBody { get; set; }
        public double AmountPercent { get; set; }
        public double Remain { get; set; }
    }
}