using SMS.DAL.Abstracts;
using SMS.DAL.Context;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Concrete.EntityFramework
{
    public class EFSubjectsDAL : EFRepositoryBase<Subjects>, ISubjectsDAL
    {
        public bool AddSubjectClasses(int subjectId, int classId)
        {
            var classes = context.Classes.Include("Subjects").Where(x => x.Id == classId).Single();
            var subject = context.Subjects.Include("Classes").Where(x => x.Id == subjectId).Single();
            subject.Classes.Add(classes);
            return context.SaveChanges() > 0 ? true : false;
        }

        public List<Subjects> NonSubjectClasses(int classId)
        {
            return (from subject in context.Subjects
                    where !(from subject1 in context.Subjects
                            from classes in subject1.Classes
                            join x in context.Classes on subject1.Id equals x.Id
                            where classes.Id == classId
                            select subject1.Id)
                    .Contains(subject.Id)
                    select subject).ToList();
        }

        public bool RemoveSubjectClasses(int subjectId, int classId)
        {
            var classes = context.Classes.Include("Subjects").Where(x => x.Id == classId).Single();
            var subject = context.Subjects.Include("Classes").Where(x => x.Id == subjectId).Single();
            subject.Classes.Remove(classes);
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
