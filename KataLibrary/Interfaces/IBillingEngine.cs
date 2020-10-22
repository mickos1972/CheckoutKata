namespace KataLibrary
{
    public interface IBillingEngine
    {
        decimal calculateTotal(ShoppingCartModel cart);
    }
}