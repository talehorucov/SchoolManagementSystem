using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMS.Entities.Entity
{
    public class Students
    {
        public Students()
        {
            Attendances = new List<Attendances>();
            ExamResults = new List<ExamResult>();
            Logging = new List<Logging>();
            StudentsMessages = new List<StudentsMessage>();

            RegDate = DateTime.Now;
            IsActive = true;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BornDate { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public DateTime RegDate { get; set; }
        public int ClassId { get; set; }
        public bool IsActive { get; set; }


        public virtual List<Attendances> Attendances { get; set; }
        public virtual List<ExamResult> ExamResults { get; set; }
        public virtual List<Logging> Logging { get; set; }
        public virtual List<StudentsMessage> StudentsMessages { get; set; }
        public virtual Classes Classes { get; set; }
    }
}
