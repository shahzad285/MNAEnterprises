using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemPurchase:BaseModel
    {
        public int ItemId {  get; set; }
        public int PurchaseId { get; set;}
        public Decimal Quantity { get; set; }
        public Decimal Price { get; set; }
    }
}
