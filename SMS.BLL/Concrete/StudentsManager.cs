using SMS.BLL.Abstracts;
using SMS.DAL.Abstracts;
using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class StudentsManager : GenericManager<Students>,IStudentsService
    {
        private readonly IStudentsDAL studentsDAL;

        public StudentsManager(IStudentsDAL studentsDAL):base(studentsDAL)
        {
            this.studentsDAL = studentsDAL;
        }

        public static ComplexStudentDashboard onlineStudent;

        public ComplexStudentDashboard StudentLogin(string username, string password)
        {
            var student = studentsDAL.StudentLogin(username, password);

            if (student != null)
            {
                return new ComplexStudentDashboard
                {
                    Id = student.Id,
                    FullName = student.Firstname + " " + student.Lastname,
                    BornDate = student.BornDate,
                    ClassId = student.ClassId,
                    ContactNo = student.ContactNo,
                    Address = student.Address
                };
            }
            else
            {
                return new ComplexStudentDashboard();
            }
        }
    }
}
