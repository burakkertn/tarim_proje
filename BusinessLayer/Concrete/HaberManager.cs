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
    public class HaberManager: IHaberService
    {
        private readonly IHaberDal _haberDal;

        public HaberManager(IHaberDal haberDal)
        {
            _haberDal = haberDal;
        }

        public void Delete(Haberler t)
        {
            _haberDal.Delete(t);    
        }

        public Haberler GetById(int id)
        {
            return _haberDal.GetById(id);
        }

        public List<Haberler> GetListAll()
        {
            return _haberDal.GetListAll();
        }

        public void HaberlerStatusToFalse(int id)
        {
            _haberDal.HaberlerStatusToFalse(id);
        }

        public void HaberlerStatusToTrue(int id)
        {
          _haberDal.HaberlerStatusToTrue(id);
        }

        public void Insert(Haberler t)
        {
            _haberDal.Insert(t);    
        }

        public void Update(Haberler t)
        {
          _haberDal.Update(t);  
        }
    }
}
