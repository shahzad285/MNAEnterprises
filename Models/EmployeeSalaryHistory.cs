using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeeSalaryHistory:BaseModel
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int OldSalary { get; set; }
    }

}
