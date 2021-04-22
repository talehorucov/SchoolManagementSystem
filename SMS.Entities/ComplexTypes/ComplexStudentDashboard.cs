using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.ComplexTypes
{
    public class ComplexStudentDashboard
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BornDate { get; set; }
        public int ClassId { get; set; }
        public string SubjectName { get; set; }
        public string Teacher { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
    }
}
