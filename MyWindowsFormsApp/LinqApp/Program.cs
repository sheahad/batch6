using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //LINQ Query Syntax to Print Numbers Greater than 3

            var result = from numbers in Num

                where numbers > 3

                select numbers;

            foreach (var item in result)

            {

                Console.WriteLine(item);

            }

            Console.ReadLine();
        }
    }
}
