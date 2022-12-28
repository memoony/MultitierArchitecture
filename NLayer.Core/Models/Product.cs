using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        // Foreign Key.
        public int CategoryId { get; set; }

        // Bir Product'ın, yalnızca 1 tane kategorisi olabileceği için Category property'si tanımlanmıştır.
        public Category Category { get; set; }

        // Bir Product'ın, yalnızca 1 tane ProductFeature'u olabileceği için ProductFeature property'si tanımlanmıştır.
        public ProductFeature ProductFeature { get; set; }
    }
}
