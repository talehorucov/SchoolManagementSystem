using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class Subjects
    {
        public Subjects()
        {
            Staffs = new List<Staffs>();
            Classes = new List<Classes>();
            ExamResults = new List<ExamResult>();
            Attendances = new List<Attendances>();
            IsActive = true;
        }

        public int Id { get; set; }
        public string SubjectName { get; set; }
        public bool IsActive { get; set; }


        public virtual List<Staffs> Staffs { get; set; }
        public virtual List<Classes> Classes { get; set; }
        public virtual List<ExamResult> ExamResults { get; set; }
        public virtual List<Attendances> Attendances { get; set; }
    }
}
