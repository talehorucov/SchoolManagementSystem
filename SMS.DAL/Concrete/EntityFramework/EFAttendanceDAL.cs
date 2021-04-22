using SMS.DAL.Abstracts;
using SMS.DAL.Context;
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
    public class EFAttendanceDAL : EFRepositoryBase<Attendances>, IAttendanceDAL
    {
        public List<ComplexAttendances> GetAttendanceForAdmin(int subjectId, DateTime date, int classId)
        {
            return (from attendances in context.Attendances
                    join student in context.Students on attendances.StudentId equals student.Id
                    join classes in context.Classes on student.ClassId equals classes.Id
                    join subject in context.Subjects on attendances.SubjectId equals subject.Id
                    where subject.Id == subjectId && attendances.AttendanceDate == date.Date && classes.Id == classId
                    select new ComplexAttendances
                    {
                        Firstname = student.Firstname,
                        IsAttend = attendances.IsAttend
                    }).AsNoTracking().ToList();
        }

        public List<ComplexAttendances> GetAttendanceForStudent(int studentId)
        {
            return (from attendance in context.Attendances
                    join student in context.Students on attendance.StudentId equals student.Id
                    join subkject in context.Subjects on attendance.SubjectId equals subkject.Id
                    where student.Id == studentId
                    select new ComplexAttendances
                    {
                        SubjectName = subkject.SubjectName,
                        AttendDate = attendance.AttendanceDate,
                        IsAttend = attendance.IsAttend
                    }).OrderBy(x=>x.AttendDate).ThenBy(x=>x.SubjectName).AsNoTracking().ToList();
        }

        public List<ComplexAttendances> GetAttendanceForTeacher(DateTime date, int classId)
        {
            return (from attendance in context.Attendances
                    join student in context.Students on attendance.StudentId equals student.Id
                    join classes in context.Classes on student.ClassId equals classes.Id
                    where attendance.AttendanceDate == date.Date && classes.Id == classId
                    select new ComplexAttendances
                    {
                        Id = student.Id,
                        Firstname = student.Firstname,
                        IsAttend = attendance.IsAttend
                    }).AsNoTracking().ToList();
        }

        public List<ComplexAttendances> GetAttendanceForTeacher(int classId)
        {
            return (from student in context.Students
             join classes in context.Classes on student.ClassId equals classes.Id
             where classes.Id == classId
             select new ComplexAttendances
             {
                 Id = student.Id,
                 Firstname = student.Firstname,
                 IsAttend = false
             }).AsNoTracking().ToList();
        }
    }
}
