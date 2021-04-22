using SMS.BLL.Abstracts;
using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class StudentsMessageManager : GenericManager<StudentsMessage>,IStudentsMessageService
    {
        private readonly IStudentsMessageDAL studentsMessageDAL;
        public StudentsMessageManager(IStudentsMessageDAL studentsMessageDAL):base(studentsMessageDAL)
        {
            this.studentsMessageDAL = studentsMessageDAL;
        }
    }
}
