using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Salary { get; set; }
    }
}
