using SMS.DAL.Abstracts;
using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Concrete.EntityFramework
{
    public class EFStudentsDAL : EFRepositoryBase<Students>, IStudentsDAL
    {

        public List<ComplexStudentDashboard> StudentDashboardsList(int studentId)
        {
            return (from staff in context.Staffs
                    from classes in staff.Classes
                    join staffClasses in context.Classes on classes.Id equals staffClasses.Id
                    join student in context.Students on classes.Id equals student.ClassId
                    join subject in context.Subjects on staff.SubjectId equals subject.Id
                    where student.Id == studentId && student.IsActive == true && staff.IsActive == true
                    select new ComplexStudentDashboard
                    {
                        SubjectName = subject.SubjectName,
                        Teacher = staff.Firstname
                    }).AsNoTracking().ToList();
        }

        public Students StudentLogin(string username, string password)
        {
            return context.Students.Where(x => x.Username == username && x.Password == password && x.IsActive == true).SingleOrDefault();
        }

        public List<ComplexStudents> StudentsList()
        {
            return (from student in context.Students
                    join classes in context.Classes on student.ClassId equals classes.Id
                    select new ComplexStudents
                    {
                        Id = student.Id,
                        Firstname = student.Firstname,
                        Lastname = student.Lastname,
                        FatherName = student.FatherName,
                        Username = student.Username,
                        Password = student.Password,
                        BornDate = student.BornDate,
                        ContactNo = student.ContactNo,
                        Address = student.Address,
                        RegDate = student.RegDate,
                        ClassName = classes.ClassName,
                        IsActive = student.IsActive
                    }).Where(x => x.IsActive == true).AsNoTracking().ToList();
        }

        public List<ComplexStudents> StudentsList(string searchFirstname)
        {
            return (from student in context.Students
                    join classes in context.Classes on student.ClassId equals classes.Id
                    select new ComplexStudents
                    {
                        Id = student.Id,
                        Firstname = student.Firstname,
                        Lastname = student.Lastname,
                        FatherName = student.FatherName,
                        Username = student.Username,
                        Password = student.Password,
                        BornDate = student.BornDate,
                        ContactNo = student.ContactNo,
                        Address = student.Address,
                        RegDate = student.RegDate,
                        ClassName = classes.ClassName,
                        IsActive = student.IsActive
                    }).Where(x => x.IsActive == true && x.Firstname.Contains(searchFirstname)).AsNoTracking().ToList();
        }
    }
}
