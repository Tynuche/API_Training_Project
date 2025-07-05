// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        
            Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webHost =>
            {
                webHost.UseStartup<Startup>();
            });
        
    }
}