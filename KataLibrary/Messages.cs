using System;

namespace KataLibrary
{
    public static class StandardMessages
    {
        public static void PleaseEnterSelectionText()
        { 
            Console.WriteLine("Please select an item to add to the basket (A,B,C,D) press x to calculate total");
        }

        public static void TotalMessage(decimal total)
        {
            Console.WriteLine($"The Total is : £{total}");
        }

        public static void YouHaveAdded(ItemModel item)
        {
            Console.WriteLine($"You have added : {item.ItemDescription} costing {item.UnitPrice}");
        }
    }
}
