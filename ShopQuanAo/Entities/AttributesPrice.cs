﻿using System;
using System.Collections.Generic;

namespace ShopQuanAo.Entities
{
    public partial class AttributesPrice
    {
        public int AttributesPriceId { get; set; }
        public int? AttributeId { get; set; }
        public int? ProductId { get; set; }
        public string? Price { get; set; }
        public string? Active { get; set; }

        public virtual Attribute? Attribute { get; set; }
        public virtual Product? Product { get; set; }
    }
}
