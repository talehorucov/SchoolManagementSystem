using SMS.DAL.Abstracts;
using SMS.DAL.Context;
using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Concrete.EntityFramework
{
    public class EFClassesDAL : EFRepositoryBase<Classes>, IClassesDAL
    {
        public bool AddStaffClasses(int staffId, int classId)
        {
            var staffs = context.Staffs.Where(x => x.Id == staffId).Single();
            var classes = context.Classes.Where(x => x.Id == classId).Single();
            staffs.Classes.Add(classes);
            return context.SaveChanges() > 0 ? true : false;
        }

        public List<ComplexClassChart> GetStudentsCount(string classStartName)
        {
            return (from classes in context.Classes
                    join student in context.Students on classes.Id equals student.ClassId
                    where classes.ClassName.StartsWith(classStartName)
                    group new { classes, student } by student.Id into complex
                    select new ComplexClassChart
                    {
                        ClassName = complex.Key,
                        SumStudent = complex.Sum(x => x.student.Id)
                    }).ToList();
        }

        public List<Classes> NonStaffClasses(int staffId)
        {
            return (from classes in context.Classes
                    where !(from staff in context.Staffs
                            from class1 in staff.Classes
                            join x in context.Staffs on staff.Id equals x.Id
                            where staff.Id == staffId
                            select class1.Id)
                    .Contains(classes.Id)
                    select classes).ToList();
        }

        public bool RemoveStaffClasses(int staffId, int classId)
        {
            var classes = context.Classes.Where(x => x.Id == classId).Single();
            var staffs = context.Staffs.Where(x => x.Id == staffId).Single();
            staffs.Classes.Remove(classes);
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
