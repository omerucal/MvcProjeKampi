using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddMessageBLL(Message message)
        {
            _messageDal.Insert(message);
        }

        public void DeleteMessageBLL(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListInboxBLL(string p)
        {
            return _messageDal.List(x => x.ReceiverMail == p);
        }

        public List<Message> GetListSendboxBLL(string p)
        {
            return _messageDal.List(x => x.SenderMail == p);
        }

        public Message GetMessageByIDBLL(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }

        public void UpdateMessageBLL(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
