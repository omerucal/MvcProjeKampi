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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void AddContentBLL(Content content)
        {
            throw new NotImplementedException();
        }

        public void DeleteContentBLL(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetContentByIDBLL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListBLL()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }

        public void UpdateContentBLL(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
