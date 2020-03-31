using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요");
            string userInput1 = Console.ReadLine();
            double number1 = double.Parse(userInput1);

            Console.WriteLine(number1 + 1);
        }
    }
}
