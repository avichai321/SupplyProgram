using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class Location
    {
        public Location()
        {
            ProductStatus1s = new HashSet<ProductStatus>();
        }

        public int LocationId { get; set; }
        public string Location1 { get; set; }

        public virtual ICollection<ProductStatus> ProductStatus1s { get; set; }
    }
}
