using System;
using System.Collections.Generic;

namespace Mission3Assignment;

public class FoodItem
{

    public FoodItem(string name, string category, int quantity, string expDate)
    {
        string itemName = "";
        string itemCategory = "";
        int itemQuantity = 0;
        string itemExpDate = "";

        itemName = name;
        itemCategory = category;
        itemQuantity = quantity;
        itemExpDate = expDate;
    }
    
    public void AddItem(List<FoodItem> foodItemsList)
    {
        // Get Item Information to Add
        Console.WriteLine("What is the item name? ");
        string itemName = Console.ReadLine();
        Console.WriteLine("What is the item category? ");
        string itemCategory = Console.ReadLine();

        int itemQuantity;
        while (true)
        {
            Console.WriteLine("What is the item quantity? ");
            string qtyInput = Console.ReadLine();
                
            // Try to parse the input as int
            if (int.TryParse(qtyInput, out itemQuantity) && itemQuantity > 0)
            {
                break; // valid positive number, exit loop
            }
                
            // If parsing fails or number is non-positive
            Console.WriteLine("Please enter a valid positive number.");
        }
        Console.WriteLine("What is the item expiration date? ");
        string itemExpDate = Console.ReadLine();
            
        // Declare and Instantiate a new FoodItem Object, pass needed variables to constructor.
        FoodItem itemObj = new FoodItem(itemName, itemCategory, itemQuantity, itemExpDate);
            
        // Add object to foodItemsList
        foodItemsList.Add(itemObj);
        Console.WriteLine("Item added successfully!\n");
    }
    
    // TODO: Method for Delete Item
    public void DeleteItem()
    {
        
    }
    
    // TODO: Method for Print List of Items
    public void ViewItems()
    {
        
    }
}