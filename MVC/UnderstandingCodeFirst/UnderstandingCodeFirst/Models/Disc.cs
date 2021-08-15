using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnderstandingCodeFirst.Models
{
    public class Disc
    {
        public int Id { get; set; }
        public float Cost { get; set; }
        [Column("MovieID")]
        public virtual Movie Movie { get; set; }

    }
}