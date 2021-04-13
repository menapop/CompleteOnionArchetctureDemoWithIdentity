using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Product : BaseEntity  
    {
        public Product()
        {
            Categories = new HashSet<Category>();
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}
