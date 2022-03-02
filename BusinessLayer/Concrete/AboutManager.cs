﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AddAboutBLL(About about)
        {
            _aboutDal.Insert(about);
        }

        public void DeleteAboutBLL(About about)
        {
            _aboutDal.Delete(about);
        }

        public About GetAboutByIDBLL(int id)
        {
            return _aboutDal.Get(x => x.AboutId == id);
        }

        public List<About> GetListBLL()
        {
            return _aboutDal.List();
        }

        public void UpdateAboutBLL(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
