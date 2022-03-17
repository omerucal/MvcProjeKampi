using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInboxBLL(string p);

        List<Message> GetListSendboxBLL(string p);

        void AddMessageBLL(Message message);

        Message GetMessageByIDBLL(int id);

        void DeleteMessageBLL(Message message);

        void UpdateMessageBLL(Message message);
    }
}
