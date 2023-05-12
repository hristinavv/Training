internal class CartItem
{
    private int itemId;
    private object? item;

    public CartItem(int itemId)
    {
        this.itemId = itemId;
    }

    public CartItem(object? item)
    {
        this.item = item;
    }

    internal void Add(CartItem newItem)
    {
        throw new NotImplementedException();
    }
}