using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}
    }
}
