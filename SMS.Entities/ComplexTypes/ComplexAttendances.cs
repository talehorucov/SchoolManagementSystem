using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Entities.ComplexTypes
{
    [NotMapped]
    public class ComplexAttendances
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string SubjectName { get; set; }
        public DateTime AttendDate { get; set; }
        public bool IsAttend { get; set; }
    }
}
