﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collection
{
    public class DinerMenu
    {
        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            addItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", 
                true, 2.99);
            addItem("BLT", "Bacon with lettuce & tomato on whole wheat", 
                false, 2.99);
            addItem("Soup of the day", "Soup of the day, with a side of potato salad", 
                false, 3.29); 
            addItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 3.05);
        }

        public void addItem(String name, String description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems = numberOfItems + 1;
            }
        }

        public MenuItem[] getMenuItems()
        {
            return menuItems;
        }
    }
}
