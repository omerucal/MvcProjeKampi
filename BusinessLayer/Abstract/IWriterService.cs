using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetListBLL();

        void AddWriterBLL(Writer writer);

        Writer GetWriterByIDBLL(int id);

        void DeleteWriterBLL(Writer writer);

        void UpdateWriterBLL(Writer writer);
    }
}
