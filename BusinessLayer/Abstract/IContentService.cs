using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetListBLL();

        List<Content> GetListByHeadingId(int id);

        void AddContentBLL(Content content);

        Content GetContentByIDBLL(int id);

        void DeleteContentBLL(Content content);

        void UpdateContentBLL(Content content);
    }
}
