using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class SubjectManager : GenericManager<Subjects>
    {
        private readonly ISubjectsDAL subjectsDAL;
        public SubjectManager(ISubjectsDAL subjectsDAL):base(subjectsDAL)
        {
            this.subjectsDAL = subjectsDAL;
        }
    }
}
