using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzTesztGitHub
{
    internal class Program
    {
        static void WriteList(List<int> list)
        {
            Console.Write("Your list: ");
            foreach (int i in list)
            {
                Console.Write(i + ", ");
            }
        }
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            int numberInput;
            do
            {
                WriteList(numberList);
                Console.WriteLine("\nGive a number to add to the list: ");
                numberInput = int.Parse(Console.ReadLine());
                if (numberInput != 0)
                {
                    numberList.Add(numberInput);
                }
            } while (numberInput != 0);

            Console.ReadKey();
        }
        
    }
}
