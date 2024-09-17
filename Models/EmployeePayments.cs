using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeePayments:BaseModel
    {
        public int Amount { get; set; }
        public bool IsAdvance { get; set; }
        public int MonthNumber { get; set; }
        public int MonthCleared { get; set; }
    }
}
