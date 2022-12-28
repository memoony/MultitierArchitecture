﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Foreign Key.
        public int ProductId { get; set; }

        // Bir ProductFeature (ürün özelliği), yalnızca 1 tane ürüne ait olabileceği için Product property'si tanımlanmıştır.
        public Product Product { get; set; }
    }
}
