using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    


namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name employy 1: ");
            string Name1 = Console.ReadLine();

            Console.WriteLine("Enter the age empoyy 1: ");
            int age1 = Convert.ToInt32(Console.ReadLine ());

            Console.WriteLine("Enter the salary employy 1: ");
            decimal sal1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter name employy 2: ");
            string Name2 = Console.ReadLine();

            Console.WriteLine("Enter the age empoyy 2: ");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the salary employy 2: ");
            decimal sal2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter name employy 3: ");
            string Name3 = Console.ReadLine();

            Console.WriteLine("Enter the age empoyy 3: ");
            int age3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the salary employy 3: ");
            decimal sal3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Select an actio a or b or c");
            string selection = Console.ReadLine();


            switch (selection)
            {
                case "a":
                    Console.WriteLine();
                    if (sal1 > sal2 && sal1 > sal3)
                        Console.WriteLine($"Max salary {sal1}");
                    if (sal2 > sal1 && sal2 > sal3)
                        Console.WriteLine($"Max salary {sal2}");
                    if (sal3 > sal1 && sal3 > sal2)
                        Console.WriteLine($"Max salary {sal3}");
                    break;
                case "b":
                    Console.WriteLine();

                    if (sal1 < sal2 && sal1 < sal3)
                        Console.WriteLine($"Min salary {sal1}");

                    if (sal2 < sal1 && sal2 < sal3)
                        Console.WriteLine($"Min salary {sal2}");

                    if (sal3 < sal1 && sal3 < sal2)
                        Console.WriteLine($"Min salary {sal3}");
                    break;
                case "c":
                    Console.WriteLine();
                    int z = ((age1 + age2 + age3) / 3);
                    Console.WriteLine($"AVR age {z}");
                    break;
                default:
                    Console.WriteLine("Wrong latter");
                    break;
            }

            Console.ReadKey();

        }

        }

    }


   
    
    
