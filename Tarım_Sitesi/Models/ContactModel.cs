using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarım_Sitesi.Models
{
    public class ContactModel
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactMail { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }
    }
}
