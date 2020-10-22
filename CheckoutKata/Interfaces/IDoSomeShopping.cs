using System;
using System.Collections.Generic;
using System.Text;
using KataLibrary;

namespace CheckoutKata.Interfaces
{
    interface IDoSomeShopping
    {
        void LetsGoToMorrisons(Dictionary<string, ItemModel> stock);
    }
}
