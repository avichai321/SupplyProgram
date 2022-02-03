using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class ProductStatus1
    {
        public int StatusId { get; set; }
        public int? LocationId { get; set; }
        public int? ProductId { get; set; }
        public int? PackageId { get; set; }
        public int? UnitInstock { get; set; }
        public int? UnitinOrder { get; set; }

        public virtual Location Location { get; set; }
        public virtual Package Package { get; set; }
        public virtual Product Product { get; set; }
    }
}
