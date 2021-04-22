using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class Staffs
    {
        public Staffs()
        {
            Classes = new List<Classes>();
            Messages = new List<Messages>();
            Logging = new List<Logging>();
            IsActive = true;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IdentityNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public DateTime BornDate { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public int SubjectId { get; set; }
        public bool IsActive { get; set; }

        public virtual List<Classes> Classes { get; set; }
        public virtual List<Messages> Messages { get; set; }
        public virtual List<Logging> Logging { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
