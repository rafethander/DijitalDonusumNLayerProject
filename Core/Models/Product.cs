using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string InnerBarcode { get; set; }

        //FK Category
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
