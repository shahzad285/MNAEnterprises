﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemPurchase:BaseModel
    {
        public int ItemId {  get; set; }
        public Item Item { get; set; }
        public int PurchaseId { get; set;}
        public Purchase Purchase { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
