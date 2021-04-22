using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.ComplexTypes
{
    public class ComplexExamResult
    {
        public int StudentId { get; set; }
        public int ExamResultId { get; set; }
        public string Firstname { get; set; }
        public string SubjectName { get; set; }
        public byte Mark { get; set; }
    }
}
