using SMS.DAL.Abstracts;
using SMS.DAL.Context;
using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Concrete.EntityFramework
{
    public class EFStaffsDAL : EFRepositoryBase<Staffs>, IStaffsDAL
    {
        public List<ComplexStaffList> StaffDashboardList(string className)
        {
            return (from student in context.Students
                    join classes in context.Classes on student.ClassId equals classes.Id
                    where classes.ClassName == className
                    select new ComplexStaffList
                    {
                        Firstname = student.Firstname + " " + student.Lastname
                    }).AsNoTracking().ToList();
        }

        public List<ComplexStaffList> StaffList()
        {
            return context.Staffs.Where(x => x.IsActive == true)
            .Join(context.Subjects, staff => staff.SubjectId, subject => subject.Id, (staff, subject) => new { staff, subject })
            .Join(context.Roles, subjectStaff => subjectStaff.staff.RoleId, role => role.Id, (subjectStaff, role) => new ComplexStaffList()
            {
                Id = subjectStaff.staff.Id,
                Firstname = subjectStaff.staff.Firstname,
                Lastname = subjectStaff.staff.Lastname,
                IdentityNo = subjectStaff.staff.IdentityNo,
                Username = subjectStaff.staff.Username,
                Password = subjectStaff.staff.Password,
                BornDate = subjectStaff.staff.BornDate,
                ContactNo = subjectStaff.staff.ContactNo,
                Salary = subjectStaff.staff.Salary,
                Address = subjectStaff.staff.Address,
                RoleName = role.RoleName,
                SubjectName = subjectStaff.subject.SubjectName,
                IsActive = subjectStaff.staff.IsActive
            }).AsNoTracking().ToList();
        }

        public List<ComplexStaffList> StaffList(string searchFirstname)
        {
            return context.Staffs.Where(x => x.IsActive == true && x.Firstname.Contains(searchFirstname))
            .Join(context.Subjects, staff => staff.SubjectId, subject => subject.Id, (staff, subject) => new { staff, subject })
            .Join(context.Roles, subjectStaff => subjectStaff.staff.RoleId, role => role.Id, (subjectStaff, role) => new ComplexStaffList()
            {
                Id = subjectStaff.staff.Id,
                Firstname = subjectStaff.staff.Firstname,
                Lastname = subjectStaff.staff.Lastname,
                IdentityNo = subjectStaff.staff.IdentityNo,
                Username = subjectStaff.staff.Username,
                Password = subjectStaff.staff.Password,
                BornDate = subjectStaff.staff.BornDate,
                ContactNo = subjectStaff.staff.ContactNo,
                Salary = subjectStaff.staff.Salary,
                Address = subjectStaff.staff.Address,
                RoleName = role.RoleName,
                SubjectName = subjectStaff.subject.SubjectName,
                IsActive = subjectStaff.staff.IsActive
            }).AsNoTracking().ToList();
        }

        public Staffs StaffLogin(string username, string password)
        {
            return context.Staffs.Where(x => x.Username == username && x.Password == password && x.IsActive == true).SingleOrDefault();
        }
    }
}
