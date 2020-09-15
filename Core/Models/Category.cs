using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        //Fk Product

        public virtual ICollection<Product> Products { get; set; }


        public Category()
        {
            Products = new Collection<Product>();
        }

    }
}
