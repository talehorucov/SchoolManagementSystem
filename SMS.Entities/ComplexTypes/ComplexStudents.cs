using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.ComplexTypes
{
    public class ComplexStudents
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BornDate { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public DateTime RegDate { get; set; }
        public string ClassName { get; set; }
        public bool IsActive { get; set; }
    }
}
