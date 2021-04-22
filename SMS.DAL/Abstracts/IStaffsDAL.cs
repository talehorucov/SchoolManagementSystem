using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Abstracts
{
    public interface IStaffsDAL : IEntityRepository<Staffs>
    {
        Staffs StaffLogin(string username, string password);
        List<ComplexStaffList> StaffDashboardList(string className);
        List<ComplexStaffList> StaffList();
        List<ComplexStaffList> StaffList(string searchFirstname);
    }
}
