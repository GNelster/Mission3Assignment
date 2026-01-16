// Garrett Nelson - IS 413 - 001
// Mission 3 Assignment
// A simple Food Bank Inventory System that allows employees / volunteers to track food items,
// track expiration dates, and manage donations and distributions.

using System;
using Mission3Assignment;
using System.Collections.Generic;

// List to hold Food Items
List<FoodItem> foodItemsList = new List<FoodItem>();

int menuChoice;

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
    if (!int.TryParse(input, out menuChoice) || menuChoice < 1 || menuChoice > 4)
    {
        Console.WriteLine(); // Padding for readability
        Console.WriteLine("Sorry, that is not a valid option. Please try again: ");
        Console.WriteLine(); // Padding for readability
        continue; // Goes back to start of loop
    }
    
    // Handle the choice
    switch (menuChoice)
    {
        case 1: 
            // Declare and Instantiate new object
            FoodItem addItem = new FoodItem("", "", 0, "");
            addItem.AddItem(foodItemsList); // Call AddItem Method with created instance
            break;
        case 2:
            // TODO: Call Delete Item Method
            break;
        case 3:
            // Declare and Instantiate new object
            FoodItem printList = new FoodItem("", "", 0, "");
            printList.ViewItems(foodItemsList); // Call ViewItems Method with created instance
            break;
        case 4:
            Console.WriteLine(); // Padding for readability
            Console.WriteLine("Goodbye! Have a great day. :)");
            return;
    }
    
    Console.WriteLine(); // Extra line for readability before printing the menu again.
}