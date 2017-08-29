using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaB.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public float TotalPrice { get; set; }
    }
}