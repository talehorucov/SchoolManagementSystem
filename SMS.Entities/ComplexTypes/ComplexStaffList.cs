using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.ComplexTypes
{
    [NotMapped]
    public class ComplexStaffList
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IdentityNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BornDate { get; set; }
        public string ContactNo { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public string RoleName { get; set; }
        public string SubjectName { get; set; }
        public string ClassName { get; set; }
        public bool IsActive { get; set; }
    }
}
