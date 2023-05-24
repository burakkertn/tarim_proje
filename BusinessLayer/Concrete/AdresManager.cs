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
   
    public class AdresManager : IAdressService
    {
        private readonly IAdresDal _adresDal;

        public AdresManager(IAdresDal adresDal)
        {
            _adresDal = adresDal;
        }

        public void Delete(Adres t)
        {
            _adresDal.Delete(t);
        }

        public Adres GetById(int id)
        {
            return _adresDal.GetById(id);   
        }

        public List<Adres> GetListAll()
        {
            return _adresDal.GetListAll();
        }

        public void Insert(Adres t)
        {
           _adresDal.Insert(t);
        }

        public void Update(Adres t)
        {
          _adresDal.Update(t);  
        }
    }
}
