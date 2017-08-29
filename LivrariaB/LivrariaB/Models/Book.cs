﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaB.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
        public float BookPrice { get; set; }
    }
}