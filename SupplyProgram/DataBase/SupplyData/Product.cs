using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class Product
    {
        public Product()
        {
            ProductStatus1s = new HashSet<ProductStatus>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<ProductStatus> ProductStatus1s { get; set; }
    }
}
