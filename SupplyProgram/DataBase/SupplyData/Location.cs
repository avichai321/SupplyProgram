using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class Location
    {
        public Location()
        {
            ProductStatus1s = new HashSet<ProductStatus1>();
        }

        public int LocationId { get; set; }
        public string Location1 { get; set; }

        public virtual ICollection<ProductStatus1> ProductStatus1s { get; set; }
    }
}
