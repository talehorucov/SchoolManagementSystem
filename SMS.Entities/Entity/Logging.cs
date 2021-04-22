using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class Logging
    {
        public Logging()
        {
            LogDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? StudentId { get; set; }
        public DateTime LogDate { get; set; }
        public string Message { get; set; }

        public virtual Staffs Staffs { get; set; }
        public virtual  Students Students { get; set; }
    }
}
