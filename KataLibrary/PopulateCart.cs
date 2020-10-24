using System;
using System.Collections.Generic;

namespace KataLibrary
{
    public class PopulateCart : IPopulateCart
    {
        public void ScanItems(ShoppingCart cart, Dictionary<string, ItemModel> Stock)
        {
            //Read the input and populate the cart
            var input = "";

            Console.WriteLine("Please select an item to add to the basket (A,B,C,D) press x to calculate total");

            while (input != "x")
            {
                input = Console.ReadLine().ToLower();

                //I know! dont judge me!
                if(input == "a" || input == "b" || input == "c" || input == "d")
                    cart.AddItem(Stock[input]);
            } 
        }
    }
}
