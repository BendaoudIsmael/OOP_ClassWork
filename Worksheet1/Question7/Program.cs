using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumbers ranNums = new RandomNumbers();

            ranNums.GenerateNumbers();

            Console.WriteLine("The generated numbers are " + ranNums.GetNumber1() + " and " + ranNums.GetNumber2()
                + ".\nPlease input their sum: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            ranNums.FindSum();

            bool isEqualAns = ranNums.IsEqual(userInput);

            if(isEqualAns) //if(isEuqalAns == true)
            {
                Console.WriteLine("Corrent Answer");
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
            }

            Console.ReadKey();

        }
    }
}
