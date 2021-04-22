using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Abstracts
{
    public interface IStudentsDAL : IEntityRepository<Students>
    {
        Students StudentLogin(string username, string password);
        List<ComplexStudents> StudentsList();
        List<ComplexStudents> StudentsList(string searchFirstname);
        List<ComplexStudentDashboard> StudentDashboardsList(int studentId);
    }
}
