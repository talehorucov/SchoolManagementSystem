using SMS.DAL.Abstracts;
using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Concrete.EntityFramework
{
    public class EFLoggingDAL : EFRepositoryBase<Logging>, ILoggingDAL
    {
        public List<ComplexLogging> GetStudents()
        {
            return (from logging in context.Logging
                    join student in context.Students on logging.StudentId equals student.Id
                    where logging.LogDate >= DateTime.Today
                    select new ComplexLogging
                    {
                        Id = logging.Id,
                        StudentName = student.Firstname + " " + student.Lastname,
                        Log = logging.Message,
                        Date = logging.LogDate
                    }).AsNoTracking().ToList();
        }

        public List<ComplexLogging> GetTeachers()
        {
            return (from logging in context.Logging
                    join staff in context.Staffs on logging.StaffId equals staff.Id
                    where logging.LogDate >= DateTime.Today
                    select new ComplexLogging
                    {
                        Id = logging.Id,
                        TeacherName = staff.Firstname + " " + staff.Lastname,
                        Log = logging.Message,
                        Date = logging.LogDate
                    }).AsNoTracking().ToList();
        }
    }
}
