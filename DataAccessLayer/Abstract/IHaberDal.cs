using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IHaberDal: IGenericDal<Haberler>
    {
        void HaberlerStatusToTrue(int id);

        void HaberlerStatusToFalse(int id);
    }
}
