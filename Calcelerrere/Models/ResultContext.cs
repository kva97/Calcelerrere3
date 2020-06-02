using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Calcelerrere.Models
{
    public class ResultContext : DbContext
    {
        
        public DbSet<Result> Results { get; set; }
    }
}