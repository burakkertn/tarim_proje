using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Adres
    {
        public int ID { get; set; }

        public string? Description1 { get; set; }
        public string? Description2 { get; set; }
        public string? Description3 { get; set; }
        public string? Description4 { get; set; }

        public string MapInfo { get; set; }

    }
}
