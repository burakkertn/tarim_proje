using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHaberService : IGenericService<Haberler>
    {
        void HaberlerStatusToTrue(int id);

        void HaberlerStatusToFalse(int id);
    }
}
