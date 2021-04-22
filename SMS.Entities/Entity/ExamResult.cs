using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class ExamResult
    {
        public int Id { get; set; }
        public int ExamTypesId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public byte Mark { get; set; }


        public virtual ExamTypes ExamTypes { get; set; }
        public virtual Students Students { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
