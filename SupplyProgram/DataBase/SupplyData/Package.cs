using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class Package
    {
        public Package()
        {
            ProductStatus1s = new HashSet<ProductStatus1>();
        }

        public int PackageId { get; set; }
        public string PackageType { get; set; }
        public int ScaleId { get; set; }

        public virtual ScaleValue Scale { get; set; }
        public virtual ICollection<ProductStatus1> ProductStatus1s { get; set; }
    }
}
