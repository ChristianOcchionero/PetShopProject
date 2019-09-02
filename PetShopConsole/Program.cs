using System;
using PetShopProject.Core.ApplicationService;
using PetShopProject.Core.ApplicationService.Impl;
using PetShopProject.Core.DomainService;
using PetShopProject.Infrastructure.Static.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace PetShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPrinter, Printer>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();

            printer.Start();
        }
    }
}
    