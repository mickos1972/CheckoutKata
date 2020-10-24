using System;
using System.Collections.Generic;
using KataLibrary;
using KataLibrary.Interfaces;

namespace CheckoutKata
{
    public class PopulateCart : IPopulateCart
    {
        public void ScanItems(IShoppingCart cart, Dictionary<string, ItemModel> Stock)
        {
            //Read the input and populate the cart
            var input = "";

            while (input != "x")
            {
                input = Console.ReadLine().ToLower();

                //I know! dont judge me!
                if (input == "a" || input == "b" || input == "c" || input == "d")
                {
                    var item = Stock[input];

                    StandardMessages.YouHaveAdded(item);
                    cart.AddItem(item);
                }
            } 
        }
    }
}
