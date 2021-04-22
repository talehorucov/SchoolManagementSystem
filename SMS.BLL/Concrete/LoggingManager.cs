using SMS.BLL.Abstracts;
using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class LoggingManager:GenericManager<Logging>,ILoggingService
    {
        private readonly ILoggingDAL loggingDAL;
        public LoggingManager(ILoggingDAL loggingDAL):base(loggingDAL)
        {
            this.loggingDAL = loggingDAL;
        }
    }
}
