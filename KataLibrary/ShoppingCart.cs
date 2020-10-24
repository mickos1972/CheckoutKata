using System.Collections.Generic;
using System.Linq;
using KataLibrary.Interfaces;

namespace KataLibrary
{
    public class ShoppingCart : IShoppingCart
    {
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();

        public void AddItem(ItemModel item)
        {            
            Items.Add(item);
        }

        public decimal GenerateTotal(List<Rule> rules)
        {
            decimal total = 0;

            var itemGroups = Items.GroupBy(x => x.ItemRule);

            foreach(var itemGroup in itemGroups)
            {
                var rule = rules.FirstOrDefault(x => x.RuleName == itemGroup.Key);

                //If no rule is found then just add up as normal.
                if (rule != null)
                {
                    var groupCount = itemGroup.Count();

                    var extra = groupCount - rule.ItemCount;

                    //If < the discount amount is bought then just add them up.
                    if(extra < 0)
                    {
                        total += itemGroup.Sum(x => x.UnitPrice);
                    }
                    else
                    {
                        total += rule.Total;
                        total += extra * itemGroup.First().UnitPrice;
                    }
                }
                else
                {
                    total += itemGroup.Sum(x => x.UnitPrice);
                }
            }

            return total;
        }
    }
}