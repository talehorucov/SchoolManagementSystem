using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class ExamResultManager : GenericManager<ExamResult>
    {
        private readonly IExamResultsDAL examResultsDAL;
        public ExamResultManager(IExamResultsDAL examResultsDAL):base(examResultsDAL)
        {
            this.examResultsDAL = examResultsDAL;
        }
    }
}
