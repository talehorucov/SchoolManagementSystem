using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Abstracts
{
    public interface IClassesDAL : IEntityRepository<Classes>
    {
        List<ComplexClassChart> GetStudentsCount(string classStartName);
        List<Classes> NonStaffClasses(int staffId);
        bool AddStaffClasses(int staffId, int classId);
        bool RemoveStaffClasses(int staffId, int classId);
    }
}
