using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.ComplexTypes
{
    public class ComplexStaffs
    {
        public int StaffId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BornDate { get; set; }
        public double Salary { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public int SubjectId { get; set; }
    }
}
