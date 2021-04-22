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
    public class EFExamResultsDAL : EFRepositoryBase<ExamResult>, IExamResultsDAL
    {
        public List<ComplexExamResult> GetExam(int examTypeId, int studentId)
        {
            return (from examResult in context.ExamResults
                    join student in context.Students on examResult.StudentId equals student.Id
                    join subject in context.Subjects on examResult.SubjectId equals subject.Id
                    join classes in context.Classes on student.ClassId equals classes.Id
                    join examType in context.ExamTypes on examResult.ExamTypesId equals examType.Id
                    where student.Id == studentId && examType.Id == examTypeId
                    select new ComplexExamResult
                    {
                        ExamResultId = examResult.Id,
                        StudentId = student.Id,
                        Firstname = student.Firstname,
                        SubjectName = subject.SubjectName,
                        Mark = examResult.Mark
                    }).OrderBy(x => x.Firstname).ThenBy(x => x.SubjectName).AsNoTracking().ToList();
        }

        public List<ComplexExamResult> GetUnCheckedExam(int classId, int examTypeId, int staffId)
        {
            return (from examResult in context.ExamResults
                    join student in context.Students on examResult.StudentId equals student.Id
                    join subject in context.Subjects on examResult.SubjectId equals subject.Id
                    join classes in context.Classes on student.ClassId equals classes.Id
                    join staff in context.Staffs on subject.Id equals staff.SubjectId
                    join examType in context.ExamTypes on examResult.ExamTypesId equals examType.Id
                    where classes.Id == classId && examType.Id == examTypeId && staff.Id == staffId
                    select new ComplexExamResult
                    {
                        ExamResultId = examResult.Id,
                        StudentId = student.Id,
                        Firstname = student.Firstname,
                        SubjectName = subject.SubjectName,
                        Mark = examResult.Mark
                    }).OrderBy(x => x.Firstname).ThenBy(x => x.SubjectName).AsNoTracking().ToList();
        }

        public List<ComplexExamResult> GetExamForAdmin(int examTypeId, int classId)
        {
            return (from examResult in context.ExamResults
                    join student in context.Students on examResult.StudentId equals student.Id
                    join subject in context.Subjects on examResult.SubjectId equals subject.Id
                    join classes in context.Classes on student.ClassId equals classes.Id
                    join examType in context.ExamTypes on examResult.ExamTypesId equals examType.Id
                    where classes.Id == classId && examType.Id == examTypeId
                    select new ComplexExamResult
                    {
                        ExamResultId = examResult.Id,
                        StudentId = student.Id,
                        Firstname = student.Firstname,
                        SubjectName = subject.SubjectName,
                        Mark = examResult.Mark
                    }).OrderBy(x => x.Firstname).ThenBy(x => x.SubjectName).AsNoTracking().ToList();
        }

        public List<ComplexExamResult> GetCheckedExam(int classId, int staffId)
        {
            return (from subject in context.Subjects
                    from classes in subject.Classes
                    join subjectClasses in context.Classes on classes.Id equals subjectClasses.Id
                    join student in context.Students on classes.Id equals student.ClassId
                    join staff in context.Staffs on subject.Id equals staff.SubjectId
                    where classes.Id == classId && staff.Id == staffId
                    select new ComplexExamResult
                    {
                        StudentId = student.Id,
                        Firstname = student.Firstname,
                        SubjectName = subject.SubjectName
                    }).OrderBy(z => z.Firstname).ThenBy(z => z.SubjectName).ToList();
        }
    }
}
