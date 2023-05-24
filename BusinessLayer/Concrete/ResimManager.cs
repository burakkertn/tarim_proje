using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ResimManager : IResimService
    {
        private readonly IResimDal _resimDal;

        public ResimManager(IResimDal resimDal)
        {
            _resimDal = resimDal;
        }

        public void Delete(Resim t)
        {
            _resimDal.Delete(t);
        }

        public Resim GetById(int id)
        {
           return _resimDal.GetById(id);
        }

        public List<Resim> GetListAll()
        {
          return _resimDal.GetListAll();
        }

        public void Insert(Resim t)
        {
           _resimDal.Insert(t);
        }

        public void Update(Resim t)
        {
           _resimDal.Update(t);
        }
    }
}
