using System;
using System.Collections.Generic;
using CheckoutKata.Interfaces;
using DataAccess;
using KataLibrary;
using KataLibrary.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CheckoutKata
{
    class Program
    {
        private static Dictionary<string, ItemModel> _stock = new Dictionary<string, ItemModel>();

        static void Main(string[] args)
        {
            //Setup some DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<IPopulateCart, PopulateCart>()
                .AddTransient<IDoSomeShopping, DoSomeShopping>()
                .AddTransient<IFakeDataAccess, FakeDataAccess>()
                .AddTransient<IShoppingCartModel, ShoppingCartModel>()
                .BuildServiceProvider();

            //Get Stock from the fake database
            var fakeDataAccess = serviceProvider.GetService<IFakeDataAccess>();
            _stock = fakeDataAccess.GetStockFromDataBase();

            var start = serviceProvider.GetService<IDoSomeShopping>();

            start.LetsGoToMorrisons(_stock);

            Console.ReadLine();
        }
    }
}
