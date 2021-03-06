﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueShopp.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string GeneralSize { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public byte[] Image { get; set; }
    }
}
