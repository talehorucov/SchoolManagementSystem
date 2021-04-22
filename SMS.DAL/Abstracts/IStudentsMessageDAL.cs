﻿using SMS.Entities.ComplexTypes;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Abstracts
{
    public interface IStudentsMessageDAL : IEntityRepository<StudentsMessage>
    {
        List<ComplexMessage> GetMessages(int studentId);
    }
}
