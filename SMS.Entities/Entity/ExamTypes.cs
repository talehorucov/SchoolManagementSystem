using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class ExamTypes
    {
        public ExamTypes()
        {
            ExamResults = new List<ExamResult>();
            IsActive = true;
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }


        public virtual List<ExamResult> ExamResults { get; set; }
    }
}
