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
    public class ClassesManager : GenericManager<Classes>,IClassesService
    {
        private readonly IClassesDAL classesDAL;

        public ClassesManager(IClassesDAL classesDAL):base(classesDAL)
        {
            this.classesDAL = classesDAL;
        }
    }
}
