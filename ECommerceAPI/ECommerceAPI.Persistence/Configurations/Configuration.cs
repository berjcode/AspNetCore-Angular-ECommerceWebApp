using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Configurations
{
   static    class Configuration
    {

        public static string ConnectionString
        {
            get
            {
                //appsettings.json için paket indir .
                // Microsoft.Extensions.Configuration



                ConfigurationManager configurationManager = new();

                //json için yeni paket. 
                //microsoft.extenisnos.configuraiton.json
                //../ bir geri gelme demektir. dosyadan cıkıyoruz.
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("SqlServer");

            }
        }
    }
}
