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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void AddHeadingBLL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void DeleteHeadingBLL(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public Heading GetHeadingByIDBLL(int id)
        {
            return _headingDal.Get(x => x.HeadingId == id);
        }

        public List<Heading> GetListBLL()
        {
            return _headingDal.List();
        }

        public List<Heading> GetListByWriterBLL(int id)
        {
            return _headingDal.List(x => x.WriterId == id);
        }

        public void UpdateHeadingBLL(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
