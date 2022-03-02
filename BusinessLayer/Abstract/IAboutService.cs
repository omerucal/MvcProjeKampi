using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetListBLL();

        void AddAboutBLL(About about);

        About GetAboutByIDBLL(int id);

        void DeleteAboutBLL(About about);

        void UpdateAboutBLL(About about);
    }
}
