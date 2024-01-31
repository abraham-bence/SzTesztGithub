using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzTesztGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            int numberInput = 0;
            do
            {
                Console.WriteLine("Give a number to add to the list: ");
                numberInput = int.Parse(Console.ReadLine());
                if (numberInput != 0)
                {
                    numberList.Add(numberInput);
                }
            } while (numberInput != 0);


            //foreach (int number in numberList)
            //{
            //    Console.WriteLine(number);
            //}

            Console.ReadKey();
        }
    }
}
