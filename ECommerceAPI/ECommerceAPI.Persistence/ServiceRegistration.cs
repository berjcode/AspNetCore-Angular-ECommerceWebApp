using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
    //Extension
        //Static olmalı
    

    public static class ServiceRegistration
    {
        //  Program.cs içerisinde bu yapıyı belirtmek gerekir.
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            //Hangi veritabanı sistemi ise onun paketini indir.
            //kodun içine connection string ve konfigurasyon yazılmaz. Düzeltilecek json dosyasına katarılacak
            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseSqlServer("Data Source=berjcode;Initial Catalog=ECommerceWebAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
        }
    }
}
