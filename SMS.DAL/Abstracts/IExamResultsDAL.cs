using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Abstracts
{
    public interface IExamResultsDAL : IEntityRepository<ExamResult>
    {
        List<ComplexExamResult> GetExam(int examTypeId, int studentId);
        List<ComplexExamResult> GetExamForAdmin(int examTypeId, int classId);
        List<ComplexExamResult> GetUnCheckedExam(int classId, int examTypeId, int staffId);
        List<ComplexExamResult> GetCheckedExam(int classId, int staffId);
    }
}
