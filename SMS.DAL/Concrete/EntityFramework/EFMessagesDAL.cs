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
    public class EFMessagesDAL : EFRepositoryBase<Messages>, IMessagesDAL
    {
    }
}
