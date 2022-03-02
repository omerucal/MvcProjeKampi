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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void AddContactBLL(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void DeleteContactBLL(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact GetContactByIDBLL(int id)
        {
            return _contactDal.Get(x => x.ContactId == id);
        }

        public List<Contact> GetListBLL()
        {
            return _contactDal.List();
        }

        public void UpdateContactBLL(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
