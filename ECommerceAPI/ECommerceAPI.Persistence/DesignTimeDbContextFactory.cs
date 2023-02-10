using ECommerceAPI.Persistence.Configurations;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ECommerceAPI.Persistence
{


  public class DesignTimeDbContextFactory :IDesignTimeDbContextFactory<ECommerceAPIDbContext>
    {

        //Bu class Shell'den  sağlıklı komut vermek için oluşturduk.

        public ECommerceAPIDbContext CreateDbContext(string[] args)
        {

            ////appsettings.json için paket indir .
            //// Microsoft.Extensions.Configuration



            //ConfigurationManager configurationManager = new();

            ////json için yeni paket. 
            ////microsoft.extenisnos.configuraiton.json
            ////../ bir geri gelme demektir. dosyadan cıkıyoruz.
            //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/ECommerceAPI.API"));
            //configurationManager.AddJsonFile("appsettings.json");


            DbContextOptionsBuilder<ECommerceAPIDbContext> dbContextOptionsBuilder = new();

            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);


            return new(dbContextOptionsBuilder.Options);
        }
               
    }
}
