using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Haberler
    {
        public int ID { get; set; }

        public string? Ttile { get; set; }

        public string? ozet { get; set; }
        public string? Description { get; set; }
        public DateTime Tarih { get; set; }

        public bool Status { get; set; }

        public string Resim { get; set; }
    }
}
