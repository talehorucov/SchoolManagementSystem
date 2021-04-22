using SMS.BLL.Abstracts;
using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class AttendancesManager : GenericManager<Attendances>,IAttendancesService
    {
        private readonly IAttendanceDAL attendanceDAL;
        public AttendancesManager(IAttendanceDAL attendanceDAL):base(attendanceDAL)
        {
            this.attendanceDAL = attendanceDAL;
        }
    }
}
