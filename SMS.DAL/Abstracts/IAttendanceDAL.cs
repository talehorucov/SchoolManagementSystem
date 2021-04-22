using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Abstracts
{
    public interface IAttendanceDAL:IEntityRepository<Attendances>
    {
        List<ComplexAttendances> GetAttendanceForAdmin(int subjectId, DateTime date, int classId);
        List<ComplexAttendances> GetAttendanceForTeacher(int classId);
        List<ComplexAttendances> GetAttendanceForTeacher(DateTime date, int classId);
        List<ComplexAttendances> GetAttendanceForStudent(int studentId);
    }
}
