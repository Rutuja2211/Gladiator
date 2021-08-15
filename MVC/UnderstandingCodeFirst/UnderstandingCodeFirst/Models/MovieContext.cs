using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UnderstandingCodeFirst.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext() : base ("name=efConn")
        {
        }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Disc> Discs { get; set; }
    }
}