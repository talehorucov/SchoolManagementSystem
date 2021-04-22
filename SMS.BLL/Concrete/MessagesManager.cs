using SMS.DAL.Abstracts;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Concrete
{
    public class MessagesManager:GenericManager<Messages>
    {
        private readonly IMessagesDAL messagesDAL;
        public MessagesManager(IMessagesDAL messagesDAL):base(messagesDAL)
        {
            this.messagesDAL = messagesDAL;
        }
    }
}
