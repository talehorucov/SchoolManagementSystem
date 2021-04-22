using SMS.DAL.Abstracts;
using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Abstracts
{
    public interface IStaffService : IGenericService<Staffs>
    {
        ComplexStaffs StaffLogin(string username, string password);
    }
}
