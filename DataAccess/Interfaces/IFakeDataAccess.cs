using System.Collections.Generic;
using KataLibrary;

namespace DataAccess
{
    public interface IFakeDataAccess
    {
        Dictionary<string, ItemModel> GetStockFromDataBase();
    }
}