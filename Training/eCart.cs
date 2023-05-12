public class eCart
{
    //Properties
    public int ItemId { get; }
    public decimal ItemPrice { get; }
    public int ItemQuantity { get; set; }
    public int UserId { get; private set; }
    public decimal CartAmount { get; }
    public static object? newItem { get; private set; }

    //Constructor
    public eCart(int eCartId, decimal initialBalance)
    {
        this.UserId = eCartId;
        this.CartAmount = (int)initialBalance;
    }
    //Make an instance
    private static readonly eCart MyeCart = new(1234, 0);
    //public List<Items> allItems = new List<Items>();
  // Console.WriteLine ($ "MyeCart {eCartId.int} was created for {userId.int} with {initialBalance.decimal})
    //Functions

    public static void DispayItems(decimal Amount, int Quantity, int Price) {
    }

    private static List<CartItem> DisplayItems()
    {
        eCartActions actions = new eCartActions();
        return actions.DisplayItems();
    }
    public static void AddItems(decimal Amount, int Quantity, int Price)
    {
        CartItem newItem = new(item: newItem);
        newItem.Add(newItem);
    }
    public static void RemoveItem(int ItemId) {
        
        {
            RemoveItem(ItemId);
        }
    }
    public static void DoNotRemoveItemNotInCart(decimal Amount, int Quantity, int Price) { }

}

internal class ShoppingCartActions
{
    public ShoppingCartActions()
    {
    }

    internal List<CartItem> GetCartItems()
    {
        throw new NotImplementedException();
    }
}



