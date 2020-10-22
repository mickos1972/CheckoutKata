using System;
using System.Collections.Generic;
using KataLibrary;

namespace DataAccess
{
    public class FakeDataAccess : IFakeDataAccess
    {
        public Dictionary<string, ItemModel> GetStockFromDataBase()
        {
            return new Dictionary<string, ItemModel>
            {
                { "a", new ItemModel { ItemName = "Cereal", UnitPrice = 3.63M }},
                { "b", new ItemModel { ItemName = "Milk", UnitPrice = 2.95M }},
                { "c", new ItemModel { ItemName = "Strawberries", UnitPrice = 7.51M }},
                { "d", new ItemModel { ItemName = "Blueberries", UnitPrice = 8.84M }}
            };
        }
    }
}
