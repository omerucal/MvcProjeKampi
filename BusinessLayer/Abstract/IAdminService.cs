using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetListBLL();

        void AddAdminBLL(Admin admin);

        Admin GetAdminByIDBLL(int id);

        void DeleteAdminBLL(Admin admin);

        void UpdateAdminBLL(Admin admin);
    }
}
