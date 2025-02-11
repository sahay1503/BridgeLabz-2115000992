using System;

class Program
{
    static void Main()
    {
        InventoryManagement inventory = new InventoryManagement();

        inventory.AddAtEnd("Laptop", 101, 10, 800);
        inventory.AddAtEnd("Phone", 102, 15, 500);
        inventory.AddAtBeginning("Tablet", 103, 8, 300);

        inventory.DisplayAllItems();
        inventory.UpdateQuantity(102, 20);
        inventory.CalculateTotalValue();
        inventory.SortByPrice();
        inventory.DisplayAllItems();
    }
}
