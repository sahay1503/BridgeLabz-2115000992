class Item
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public Item Next;

    public Item(string itemName, int itemId, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemId;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}
