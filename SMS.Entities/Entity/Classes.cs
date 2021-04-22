using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class Classes
    {
        public Classes()
        {
            Staffs = new List<Staffs>();
            Students = new List<Students>();
            Messages = new List<Messages>();
            Subjects = new List<Subjects>();
            IsActive = true;
        }

        public int Id { get; set; }
        public string ClassName { get; set; }
        public bool IsActive { get; set; }


        public virtual List<Staffs> Staffs { get; set; }
        public virtual List<Students> Students { get; set; }
        public virtual List<Messages> Messages { get; set; }
        public virtual List<Subjects> Subjects { get; set; }
    }
}
