using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetListBLL();

        void AddCategoryBLL(Category category);

        Category GetCategoryByIDBLL(int id);

        void DeleteCategoryBLL(Category category);

        void UpdateCategoryBLL(Category category);
    }
}
