using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class StudentsMessage
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public int StudentId { get; set; }
        public bool IsRead { get; set; }


        public virtual Messages Messages { get; set; }
        public virtual Students Students { get; set; }
    }
}
