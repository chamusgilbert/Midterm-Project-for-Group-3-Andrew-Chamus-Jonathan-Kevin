﻿using System;
namespace Midterm_Project_for_Group
{
    class View
    {
        public static void MainMenu()
        {
            Console.WriteLine("Here are your  Options");
            Console.WriteLine("1. View Menu");
            Console.WriteLine("2. Add menu item to your order");
            Console.WriteLine("3. Remove menu item from your order");
            Console.WriteLine("4. Checkout");
            bool userChoice = int.TryParse(Console.ReadLine(), out int userC);
            if (userChoice == false || userC < 1 || userC > 4)
            {
                Console.WriteLine("That is not a valid Menu option");
                MainMenu();
            }

        }

    }
}