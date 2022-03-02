﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInboxBLL();

        List<Message> GetListSendboxBLL();

        void AddMessageBLL(Message message);

        Message GetMessageByIDBLL(int id);

        void DeleteMessageBLL(Message message);

        void UpdateMessageBLL(Message message);
    }
}
