using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class ScaleValue
    {
        public ScaleValue()
        {
            Packages = new HashSet<Package>();
        }

        public int ScaleId { get; set; }
        public string ScalesTypes { get; set; }

        public virtual ICollection<Package> Packages { get; set; }
    }
}
