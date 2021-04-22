using SMS.DAL.Abstracts;
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
    public class EFStudentsMessageDAL : EFRepositoryBase<StudentsMessage>, IStudentsMessageDAL
    {
        public List<ComplexMessage> GetMessages(int studentId)
        {
            return (from studentMessage in context.StudentsMessages
                    join message in context.Messages on studentMessage.MessageId equals message.Id
                    join staff in context.Staffs on message.StaffId equals staff.Id
                    where studentMessage.StudentId == studentId && studentMessage.IsRead == false
                    select new ComplexMessage
                    {
                        Id = studentMessage.Id,
                        StaffName = staff.Firstname + " " + staff.Lastname,
                        Title = message.Title,
                        Text = message.Text,
                        Date = message.SendingDate
                    }).AsNoTracking().ToList();
        }
    }
}
