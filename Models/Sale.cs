using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sale:BaseModel
    {
        public Trader Trader { get; set; }
        public int TraderId { get; set; }
        public DateTime? AgreedPaymentDate { get; set; }
    }
}
