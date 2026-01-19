// Garrett Nelson - IS 413 - 001
// Mission 3 Assignment
// A simple Food Bank Inventory System that allows employees / volunteers to track food items,
// track expiration dates, and manage donations and distributions.

using System;
using Mission3Assignment;
using System.Collections.Generic;

// List to hold Food Items
List<FoodItem> foodItemsList = new List<FoodItem>();

// Menu System
while (true)
{
    Console.WriteLine("Hello, welcome to the Food Bank Inventory Management System. " +
                      "Please choose an option below to get started (1-4): ");
    Console.WriteLine("1. Add Food Items");
    Console.WriteLine("2. Delete Food Items");
    Console.WriteLine("3. View Current Food Items");
    Console.WriteLine("4. Exit Program");
    
    string input = Console.ReadLine();
    
    // Try to convert string -> int
    if (!int.TryParse(input, out int menuChoice) || menuChoice < 1 || menuChoice > 4)
    {
        Console.WriteLine("\nSorry, that is not a valid option. Please try again: \n");
        continue; // Goes back to start of loop
    }
    
    // Handle the choice
    switch (menuChoice)
    {
        case 1: 
            // Declare and Instantiate new object to call method
            FoodItem addItem = new FoodItem("", "", 0, "");
            addItem.AddItem(foodItemsList); // Call AddItem Method with created instance
            break;
        case 2:
            // Declare and Instantiate new object to call method
            FoodItem deleteItem = new FoodItem("", "", 0, "");
            deleteItem.DeleteItem(foodItemsList);
            break;
        case 3:
            // Declare and Instantiate new object to call method
            FoodItem printList = new FoodItem("", "", 0, "");
            printList.ViewItems(foodItemsList); // Call ViewItems Method with created instance
            break;
        case 4:
            Console.WriteLine("\nGoodbye! Have a great day. :)");
            return;
    }
    
    Console.WriteLine(); // Extra line for readability before printing the menu again.
}