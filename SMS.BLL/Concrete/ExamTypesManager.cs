using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class ExamTypesManager:GenericManager<ExamTypes>
    {
        private readonly IExamTypesDAL examTypesDAL;

        public ExamTypesManager(IExamTypesDAL examTypesDAL) : base(examTypesDAL)
        {
            this.examTypesDAL = examTypesDAL;
        }
    }
}
