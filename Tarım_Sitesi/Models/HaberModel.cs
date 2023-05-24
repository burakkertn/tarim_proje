using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarım_Sitesi.Models
{
    public class HaberModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
