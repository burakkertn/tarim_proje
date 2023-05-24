using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)

        { 
        //---------------------------------------Program.cs tarafında düzenleme (5.0 da StarUp.cs tarafında-------------------------------------------------------------------
                services.AddControllersWithViews();
                services.AddScoped<IServiceService, ServiceManager>();
                services.AddScoped<IServisDal, EnServiceDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<ITeamService, TeamManager>();
                services.AddScoped<ITeamDal, EnTeamDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IHaberService, HaberManager>();
                services.AddScoped<IHaberDal, EnHaberDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IResimService, ResimManager>();
                services.AddScoped<IResimDal, EnResimDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IAdressService, AdresManager>();
                services.AddScoped<IAdresDal, EnAdresDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IContactService, ContactManager>();
                services.AddScoped<IContactDal, EnContactDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<ISosyalService, SosyalManager>();
                services.AddScoped<ISosyalDal, EnSosyalDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IAboutService, AboutManager>();
                services.AddScoped<IAboutDal, EnAboutDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IAdminService, AdminManager>();
                services.AddScoped<IAdminDal, EnAdminDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
    }
}
}