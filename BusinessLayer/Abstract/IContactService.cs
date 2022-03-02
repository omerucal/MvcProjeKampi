using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetListBLL();

        void AddContactBLL(Contact contact);

        Contact GetContactByIDBLL(int id);

        void DeleteContactBLL(Contact contact);

        void UpdateContactBLL(Contact contact);
    }
}
