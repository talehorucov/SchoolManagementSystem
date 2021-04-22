using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class Roles
    {
        public Roles()
        {
            Staffs = new List<Staffs>();
            IsActive=true;
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }


        public virtual List<Staffs> Staffs { get; set; }
    }
}
