using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetListBLL()
        {
            return _categoryDal.List();
        }

        public void AddCategoryBLL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetCategoryByIDBLL(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public void DeleteCategoryBLL(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void UpdateCategoryBLL(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
