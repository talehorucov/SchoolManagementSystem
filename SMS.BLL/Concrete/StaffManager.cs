using SMS.BLL.Abstracts;
using SMS.DAL.Abstracts;
using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.BLL.Concrete
{
    public class StaffManager : GenericManager<Staffs>,IStaffService
    {
        private readonly IStaffsDAL staffsDAL;

        public StaffManager(IStaffsDAL staffsDAL):base(staffsDAL)
        {
            this.staffsDAL = staffsDAL;
        }

        public static ComplexStaffs onlineStaff;
        public ComplexStaffs StaffLogin(string username, string password)
        {
            var staff = staffsDAL.StaffLogin(username, password);

            if (staff != null)
            {
                return new ComplexStaffs
                {
                    StaffId = staff.Id,
                    Firstname = staff.Firstname,
                    Lastname = staff.Lastname,
                    BornDate = staff.BornDate,
                    ContactNo = staff.ContactNo,
                    Address = staff.Address,
                    Salary = staff.Salary,
                    RoleId = staff.RoleId,
                    SubjectId = staff.SubjectId
                };
            }
            else
            {
                return new ComplexStaffs();
            }
        }
    }
}
