using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            string choice = "";
            while (choice != "6")
            {
                Console.WriteLine("\tAssignment One Questions");
                Console.WriteLine("1. Prime Number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\tEnter your choice: ");
                choice = Console.ReadLine();
                int num1, num2;
                string str1, str2;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter your number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.isPrime(num1));
                        break;
                    case "2":
                        Console.WriteLine("Enter your number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.sumDigits(num1));
                        break;
                    case "3":
                        Console.WriteLine("Enter your string: ");
                        str1 = Console.ReadLine();
                        Console.WriteLine(client.reverseString(str1));
                        break;
                    case "4":
                        Console.WriteLine("Enter HTML tags: ");
                        str1 = Console.ReadLine();
                        Console.WriteLine("Enter your data: ");
                        str2 = Console.ReadLine();
                        Console.WriteLine(client.htmlOut(str1, str2));
                        break;
                    case "5":
                        Console.WriteLine("Ascending (A) or Descending (D)?");
                        str1 = Console.ReadLine();
                        Console.WriteLine("Enter your numbers, separated by commas: ");
                        str2 = Console.ReadLine();
                        Console.WriteLine(client.sortNums(str1, str2));
                        break;
                }
            }
        }
    }
}
