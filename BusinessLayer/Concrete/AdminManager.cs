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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AddAdminBLL(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void DeleteAdminBLL(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Admin GetAdminByIDBLL(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public List<Admin> GetListBLL()
        {
            return _adminDal.List();
        }

        public void UpdateAdminBLL(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
