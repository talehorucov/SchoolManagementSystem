using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class Attendances
    {
        public Attendances()
        {
            IsAttend = true;
        }

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool IsAttend { get; set; }


        public virtual Students Students { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
