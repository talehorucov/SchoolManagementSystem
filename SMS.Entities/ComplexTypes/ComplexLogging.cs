using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.ComplexTypes
{
    public class ComplexLogging
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public string Log { get; set; }
        public DateTime Date { get; set; }
    }
}
