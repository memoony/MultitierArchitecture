using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        // Bir Category içerisinde birden fazla ürün olabileceği için Products property'si ICollection şeklinde tanımlanmıştır.
        public ICollection<Product> Products { get; set; }
    }
}
