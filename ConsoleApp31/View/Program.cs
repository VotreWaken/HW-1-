using ConsoleApp31.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static public Controller controller_ = new Controller();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Display All Information");
                Console.WriteLine("2. Display All Names");
                Console.WriteLine("3. Display All Colors");
                Console.WriteLine("4. Display Max Calories");
                Console.WriteLine("5. Display Min Calories");
                Console.WriteLine("6. Display Average Calories");
                Console.WriteLine("7. Display Vegetable Count");
                Console.WriteLine("8. Display Fruits Count");
                Console.WriteLine("9. Display Vegetable and Fruits By Choosen Color");
                Console.WriteLine("10. Display Vegetable and Fruits By Every Color");
                Console.WriteLine("11. Display Vegetable and Fruits Under Concreate Calories");
                Console.WriteLine("12. Display Vegetable and Fruits Upper Concreate Calories");
                Console.WriteLine("13. Display Vegetable and Fruits By Concreate Diapason Calories");
                Console.WriteLine("14. Display Vegetable and Fruits By Color Red And Yellow");
                int choice;
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        controller_.Show();
                        Console.ReadKey();
                        break;
                    case 2:
                        controller_.ShowName();
                        Console.ReadKey();
                        break;
                    case 3:
                        controller_.ShowColors();
                        Console.ReadKey();
                        break;
                    case 4:
                        controller_.MaxCalories();
                        Console.ReadKey();
                        break;
                    case 5:
                        controller_.MinCalories();
                        Console.ReadKey();
                        break;
                    case 6:
                        controller_.AvgCalories();
                        Console.ReadKey();
                        break;
                    case 7:
                        controller_.ShowCountVegetables();
                        Console.ReadKey();
                        break;
                    case 8:
                        controller_.ShowCountFruits();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("Type Color:");
                        controller_.ShowCountFruitsAndVegetablesByChooseColor(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case 10:
                        controller_.ShowCountEveryColor();
                        Console.ReadKey();
                        break;
                    case 11:
                        controller_.ShowFruitsVegetablesUnderCalories();
                        Console.ReadKey();
                        break;
                    case 12:
                        controller_.ShowFruitsVegetablesUpperCalories();
                        Console.ReadKey();
                        break;
                    case 13:
                        controller_.ShowFruitsVegetablesByDiapasonCalories();
                        Console.ReadKey();
                        break;
                    case 14:
                        controller_.ShowFruitsVegetablesWithRedYellowColor();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Error Input Choice");
                        break;
                }
            }
        }
    }
}
