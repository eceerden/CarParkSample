using CarParkSample.Models.ORM;
using CarParkSample.Models.ORM.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CarParkSample 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            string data = new WebClient().DownloadString("https://northwind.now.sh/api/suppliers%22");
            List<Record> records = JsonConvert.DeserializeObject<List<Record>>(data);
            

            
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });




        //string data = File.ReadAllText(@"C:\Users\Ece\source\repos\CSharpIntro2json\source\products.json");

        //Record[] jsondata = JsonConvert.DeserializeObject<Record[]>(data);

       











    }
}
