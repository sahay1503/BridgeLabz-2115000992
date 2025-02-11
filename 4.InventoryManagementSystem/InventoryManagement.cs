class InventoryManagement
{
    private Item head = null;

    // Add an item at the beginning
    public void AddAtBeginning(string itemName, int itemId, int quantity, double price)
    {
        Item newItem = new Item(itemName, itemId, quantity, price);
        newItem.Next = head;
        head = newItem;
        Console.WriteLine("Item added at the beginning.");
    }

    // Add an item at the end
    public void AddAtEnd(string itemName, int itemId, int quantity, double price)
    {
        Item newItem = new Item(itemName, itemId, quantity, price);
        if (head == null)
        {
            head = newItem;
            return;
        }

        Item temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newItem;
        Console.WriteLine("Item added at the end.");
    }

    // Add an item at a specific position (1-based index)
    public void AddAtPosition(string itemName, int itemId, int quantity, double price, int position)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(itemName, itemId, quantity, price);
            return;
        }

        Item newItem = new Item(itemName, itemId, quantity, price);
        Item temp = head;
        int count = 1;

        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }

        newItem.Next = temp.Next;
        temp.Next = newItem;
        Console.WriteLine($"Item added at position {position}.");
    }

    // Remove an item by Item ID
    public void RemoveItem(int itemId)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        if (head.ItemID == itemId)
        {
            head = head.Next;
            Console.WriteLine($"Item {itemId} removed.");
            return;
        }

        Item temp = head, prev = null;
        while (temp != null && temp.ItemID != itemId)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        prev.Next = temp.Next;
        Console.WriteLine($"Item {itemId} removed.");
    }

    // Update item quantity by Item ID
    public void UpdateQuantity(int itemId, int newQuantity)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemId)
            {
                temp.Quantity = newQuantity;
                Console.WriteLine($"Item {itemId} quantity updated to {newQuantity}.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Search for an item by Item ID
    public void SearchByItemID(int itemId)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemId)
            {
                Console.WriteLine($"Found Item -> ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Search for an item by Item Name
    public void SearchByItemName(string itemName)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Found Item -> ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Calculate total inventory value
    public void CalculateTotalValue()
    {
        double totalValue = 0;
        Item temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine($"Total Inventory Value: {totalValue}");
    }

    // Display all items
    public void DisplayAllItems()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Console.WriteLine("Inventory List:");
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
            temp = temp.Next;
        }
    }

    // Sort inventory by Item Name (Bubble Sort)
    public void SortByName()
    {
        if (head == null || head.Next == null)
            return;

        bool swapped;
        do
        {
            swapped = false;
            Item temp = head;
            while (temp.Next != null)
            {
                if (string.Compare(temp.ItemName, temp.Next.ItemName, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    // Swap data
                    Swap(temp, temp.Next);
                    swapped = true;
                }
                temp = temp.Next;
            }
        } while (swapped);

        Console.WriteLine("Inventory sorted by Name.");
    }

    // Sort inventory by Price (Bubble Sort)
    public void SortByPrice()
    {
        if (head == null || head.Next == null)
            return;

        bool swapped;
        do
        {
            swapped = false;
            Item temp = head;
            while (temp.Next != null)
            {
                if (temp.Price > temp.Next.Price)
                {
                    // Swap data
                    Swap(temp, temp.Next);
                    swapped = true;
                }
                temp = temp.Next;
            }
        } while (swapped);

        Console.WriteLine("Inventory sorted by Price.");
    }

    // Swap two nodes (used in sorting)
    private void Swap(Item a, Item b)
    {
        (a.ItemName, b.ItemName) = (b.ItemName, a.ItemName);
        (a.ItemID, b.ItemID) = (b.ItemID, a.ItemID);
        (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
        (a.Price, b.Price) = (b.Price, a.Price);
    }
}