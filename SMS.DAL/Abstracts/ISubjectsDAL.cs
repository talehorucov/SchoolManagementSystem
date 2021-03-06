using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Abstracts
{
    public interface ISubjectsDAL:IEntityRepository<Subjects>
    {
        List<Subjects> NonSubjectClasses(int classId);
        bool AddSubjectClasses(int subjectUd, int classId);
        bool RemoveSubjectClasses(int subjectId, int classId);
    }
}
