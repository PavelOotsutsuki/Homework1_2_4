using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int conditionMultiplicity1 = 3;
            int conditionMultiplicity2 = 5;
            int numberMax = 100;
            int numberMin = 0;
            int sum=0;

            number = random.Next(numberMin, numberMax+1);

            for (int i = 1; i < number+1; i++)
            {
                if (i%conditionMultiplicity1 == 0 || i % conditionMultiplicity2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("У числа " + number + " сумма равна " + sum);
        }
    }
}