using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.UI
{
    public class ChalOneUI
    {
        private readonly KomodoMenuRepo _KMenu = new KomodoMenuRepo();
        public void Run()
        {            
            RunMenu();
        }

        private void RunMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the option you would like to select: \n" +
                    "1. Show all menu items.\n" +
                    "2. Add new menu item. \n" +
                    "3. Remove menu item. \n" +
                    "4. Exit. \n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                    case "one":
                        break;
                    case "2":
                    case "two":
                        break;
                    case "3":
                    case "three":
                        break;
                    case "4":
                    case "four":
                    case "exit":
                        keepRunning = false;
                        break;
                    default: Console.WriteLine("Please enter a valid selection above. \n"+
                        "Press any key to continue ...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void ShowFullMenu()
        {
            Console.Clear();
            List<KomodoMenu> menuList = _KMenu.GetMenuItems();
            foreach (KomodoMenu item in menuList)
            {
                
            }
        }
        private void DisplayMenuStuff(KomodoMenu menu)
        {
            Console.WriteLine($"");
        }

    }
}
