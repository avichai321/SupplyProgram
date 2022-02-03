﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyProgarmOperations
{

    public class FullProductclass 
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Product { get; set; }
        public string Package { get; set; }
        public string Scale { get; set; }
        public int? UnitInStock { get; set; }
        public int? UnitInOrder { get; set; }

    
    }
}
