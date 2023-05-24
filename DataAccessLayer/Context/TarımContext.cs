using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class TarımContext: IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EIDVOSTRO03\\BURAKSERVER;database= DbTarim;integrated security=true");
        }
        public DbSet<Adres> Adresler { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Haberler> Haberler { get; set; }

        public DbSet<Resim> Resimler { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<SosyalMedya> SosyalMedyas { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
