using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetListBLL();

        void AddHeadingBLL(Heading heading);

        Heading GetHeadingByIDBLL(int id);

        void DeleteHeadingBLL(Heading heading);

        void UpdateHeadingBLL(Heading heading);
    }
}
