using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class RolesManager : GenericManager<Roles>
    {
        private readonly IRolesDAL rolesDAL;

        public RolesManager(IRolesDAL rolesDAL) : base(rolesDAL)
        {
            this.rolesDAL = rolesDAL;
        }
    }
}
