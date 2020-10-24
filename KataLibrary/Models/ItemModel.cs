using System;
using System.Collections.Generic;
using System.Text;

namespace KataLibrary
{
    //The rule was going to be used to work out what discount should be applied
    //I was going to write like a rules engine to say how many item b's do i have in the 
    //dictionary and then apply the appropriate rule. but ive spent waaaaay too much time
    //Its funny when you get going the time flies by.
    public class ItemModel
    {
        public string ItemSKU { get; set; }
        public string ItemDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public string ItemRule { get; set; }
    }
}
