using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepo<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var c = new TarımContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new TarımContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new TarımContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new TarımContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new TarımContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
