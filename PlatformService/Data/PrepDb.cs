using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        private const int CountData = 10;

        private static readonly string[] CostData = {"Free", "1", "10", "100", "1000"};
        private static readonly string[] PublisherData = {"Microsoft", "Oracle", "Intel", "AMD", "IBM"};


        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("Заполняем БД тестовыми данными");

                var random = new Random();

                for (var i = 0; i < CountData; i++)
                {
                    var name = "";
                    for (var j = 0; j < 10; j++)
                        name += (char) random.Next('A', 'Z' + 1);
                    
                    context.Platforms.Add(new Platform()
                    {
                        Name = name,
                        Publisher = PublisherData[random.Next(PublisherData.Length)],
                        Cost = CostData[random.Next(CostData.Length)],
                    });
                }

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("В БД есть тестовые данные");
            }
        }
    }
}