using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Purchase:BaseModel
    {
        public int TraderId { get; set; }
        public Trader Trader { get; set; }

    }
}
