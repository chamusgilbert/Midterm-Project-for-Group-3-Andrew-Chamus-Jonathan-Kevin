﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Midterm_Project_for_Group
{//Chamus
    class FoodMenu
    {

        public static List<MenuItem> MakeFoodMenu()
        {

            //This is for making our Original Menu, where our customer/console user will choose from;

            int x = 0; // This will be added to the MenuItem as it is added to the mcMenu
            string path = @"C:\Users\Grand Circus Student\source\repos\Midterm-Project-for-Group-3-Andrew-Chamus-Jonathan-Kevin\McMenu.txt";
            List<MenuItem> mcMenu = new List<MenuItem>();
            StreamReader menu = new StreamReader(path);
            while (true)
            {

                string foodLine = menu.ReadLine();
                bool works = double.TryParse(menu.ReadLine(), out double costLine);
                x++;
                MenuItem item = new MenuItem(foodLine, costLine, x);
                mcMenu.Add(item);

                if (foodLine == null)
                {
                    break;
                }
            }
            return mcMenu;
        }

        public static void Option1ShowList(List<MenuItem> foodMenu)
        {
            //This Method is called when the ConsoleUser chooses option 1 from the MainMenu

            foreach (MenuItem line in foodMenu)
            {
                Console.WriteLine(line.menuLine);
            }

        }
    }

    class MenuItem
    {
        //Instance Variables

        public string itemName;
        public double itemCost;
        public bool category = false;
        public string menuLine;
        public int menuNumber;


        public MenuItem(string itemName, double cost, int x)
        {
            //This is our MenuItem Constructor

            this.itemName = itemName;
            this.itemCost = cost;
            this.menuNumber = x;
            this.menuLine = MenuLine(itemName, itemCost, this.menuNumber);

        }
        public static string MenuLine(string name, double cost, int x)
        {
            //This method will constuct the menuLine. This is used only for presenting all of the MenuItem objects' instance variables at once.

            string costString = cost.ToString();
            return string.Format("{0,1}{1,30}{2,20}", x, name, costString);
        }
    }
}
