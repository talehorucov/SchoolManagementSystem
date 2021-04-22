using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Abstracts
{
    public interface IStudentsService : IGenericService<Students>
    {
        ComplexStudentDashboard StudentLogin(string username, string password);
    }
}
