using System;
using System.Collections.Generic;

namespace ShopQuanAo.Entities
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? Discount { get; set; }
        public int? Total { get; set; }
        public DateTime? ShipDate { get; set; }

        public virtual Order? Order { get; set; }
    }
}
