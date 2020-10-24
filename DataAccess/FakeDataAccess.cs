using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using KataLibrary;

namespace DataAccess
{
    //this could be a real DAL but i just put a few items in for stock.
    public class FakeDataAccess : IFakeDataAccess
    {
        public Dictionary<string, ItemModel> GetStockFromDataBase()
        {
            return new Dictionary<string, ItemModel>
            {
                { "a", new ItemModel { ItemDescription = "Cereal", UnitPrice = 3.63M, ItemRule = "a" }},
                { "b", new ItemModel { ItemDescription = "Milk", UnitPrice = 2.95M, ItemRule = "b" }},
                { "c", new ItemModel { ItemDescription = "Strawberries", UnitPrice = 7.51M, ItemRule = "c" }},
                { "d", new ItemModel { ItemDescription = "Blueberries", UnitPrice = 8.84M, ItemRule = "d" }}
            };
        }
        
        public List<Rule> GetRules()
        {
            return new List<Rule>
            {
                new Rule { ItemCount=3, RuleName="a", Total=10M},
                new Rule { ItemCount=3, RuleName="b", Total=20M},
                new Rule { ItemCount=3, RuleName="c", Total=30M},
                new Rule { ItemCount=3, RuleName="d", Total=40M},
            };
        }
    }
}
