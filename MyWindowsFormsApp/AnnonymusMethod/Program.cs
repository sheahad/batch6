using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymusMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();

            Action ShowAction = Show;
            ShowAction();

            ShowName("Ali");
            Action<string> ShowNameAction = ShowName;
            ShowNameAction("Ali");

            int resulReturn10 = Return10();
            Console.WriteLine("Return10: " + resulReturn10);
            Func<int> resulReturn10Func = Return10;
            Console.WriteLine("Return10: " + resulReturn10Func().ToString());


            int resultAdd = Add(1, 2);
            Console.WriteLine("Add: "+resultAdd);
            Func<int, int, int> resultAddFunc = Add;
            Console.WriteLine("Add: " + resultAddFunc(1,2).ToString());


            Func<int, int, int> AddFunc = (int firstNumber, int secondNumber) => { return firstNumber + secondNumber;};
            Console.WriteLine("AddFunc: " + AddFunc(5, 9).ToString());

            Func<int, int, int> AddFunc2 = (firstNumber, secondNumber) => { return firstNumber + secondNumber; };
            Console.WriteLine("AddFunc2: " + AddFunc2(5, 9).ToString());

            int resultMul = Mul(2, 3);
            Console.WriteLine("Multiply: "+resultMul);




            Console.ReadKey();


        }

        static void Show()
        {
            Console.WriteLine("Method with no argument return!");
            
        }
        static void ShowName(string name)
        {
            Console.WriteLine("Method with no return!");
            Console.WriteLine(name);
            
        }

        static int Return10()
        {
            return 10;
        }
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
