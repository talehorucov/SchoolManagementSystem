using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class Messages
    {
        public Messages()
        {
            StudentsMessages = new List<StudentsMessage>();
            SendingDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int ClassId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime SendingDate { get; set; }


        public virtual Staffs Staffs { get; set; }
        public virtual Classes Classes { get; set; }
        public virtual List<StudentsMessage> StudentsMessages { get; set; }
    }
}
