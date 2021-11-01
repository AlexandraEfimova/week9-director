using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Alexandra\Downloads\programm\shoppingList";
            string fileName = @"\\myShoppingList.txt";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Do you want to make a shopping list? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter you shopping wish:");
                    string userWish = Console.ReadLine();
                    myShoppingList.Add(userWish);

                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();
            foreach (string wish in myShoppingList)
            {
                Console.WriteLine($"Your shopping list: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
