using System;
using System.Collections.Generic;

namespace Race
{
    public class Menu
    {
        // Methods
        public void ShowMenu()
        {
            Console.WriteLine("****************");
            Console.WriteLine("MENU");
            Console.WriteLine("****************");

            int item = 1;
            int enumItem = 0;

            foreach (MenuOptions option in Enum.GetValues(typeof(MenuOptions)))
            {
                string menuItem = Enum.GetName(typeof(MenuOptions), enumItem);

                if (menuItem.StartsWith("HEADING") == true)
                {
                    menuItem = menuItem.Substring(8);
                    menuItem = menuItem.Replace('_', ' ');
                    Console.WriteLine();
                    Console.WriteLine($"{menuItem}");
                }

                else if (menuItem.StartsWith("IGNORE") == true)
                {

                }

                else
                {
                    menuItem = menuItem.Replace('_', ' ');
                    Console.WriteLine($"  {item} - {menuItem}");
                    item++;
                }

                enumItem++;
            }

            Console.WriteLine();
        }


        public int ChooseMenuOption()
        {
            Console.WriteLine($"Select an option:");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            return choice;
        }


    }
}
