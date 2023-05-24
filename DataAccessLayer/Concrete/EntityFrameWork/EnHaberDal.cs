using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EnHaberDal : GenericRepo<Haberler>, IHaberDal
    {
        public void HaberlerStatusToFalse(int id)
        {
            using var context = new TarımContext();
            Haberler p = context.Haberler.Find(id);
            p.Status = false;
            context.SaveChanges();

        }

        public void HaberlerStatusToTrue(int id)
        {
            using var context = new TarımContext();
            Haberler p = context.Haberler.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
