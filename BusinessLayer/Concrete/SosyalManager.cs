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
    public class SosyalManager : ISosyalService
    {
        ISosyalDal _sosyalDal;

        public SosyalManager(ISosyalDal sosyalDal)
        {
            _sosyalDal = sosyalDal;
        }

        public void Delete(SosyalMedya t)
        {
            _sosyalDal.Delete(t);   
        }

        public SosyalMedya GetById(int id)
        {
          return  _sosyalDal.GetById(id);
        }

        public List<SosyalMedya> GetListAll()
        {
           return _sosyalDal.GetListAll();
        }

        public void Insert(SosyalMedya t)
        {
            _sosyalDal.Insert(t);
        }

        public void Update(SosyalMedya t)
        {
          _sosyalDal.Update(t);
        }
    }
}
