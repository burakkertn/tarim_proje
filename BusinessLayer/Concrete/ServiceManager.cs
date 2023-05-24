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
    public class ServiceManager: IServiceService
    {
        private readonly IServisDal _servisDal;

        public ServiceManager(IServisDal servisDal)
        {
            _servisDal = servisDal;
        }

        public void Delete(Service t)
        {
            _servisDal.Delete(t);
        }

        public Service GetById(int id)
        {
           return _servisDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
             return _servisDal.GetListAll();
        }

        public void Insert(Service t)
        {
            _servisDal.Insert(t);
        }

        public void Update(Service t)
        {
            _servisDal.Update(t);
        }
    }
}
