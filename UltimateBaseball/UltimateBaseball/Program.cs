﻿using System;

namespace UltimateBaseball
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("숫자야구게임");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("> 수비수가 고른 숫자 ");
            int number1 = 3;
            int number2 = 1;
            int number3 = 9;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.WriteLine("> 첫 번째 숫자를 입력하세요.");
            int guess1 = int.Parse(Console.ReadLine());
            Console.WriteLine("> 두 번째 숫자를 입력하세요.");
            int guess2 = int.Parse(Console.ReadLine());
            Console.WriteLine("> 세 번째 숫자를 입력하세요.");
            int guess3 = int.Parse(Console.ReadLine());

            Console.WriteLine("> 공격수가 고른 숫자");
            Console.WriteLine(guess1);
            Console.WriteLine(guess2);
            Console.WriteLine(guess3);

            if (guess1 == guess2 || guess1 == guess3 || guess2 == guess3)
            {
                Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
            }
            else
            {
                int strikeCount = 0;
                int ballCount = 0;

                if (guess1 == number1)
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess1 == number2 || guess1 == number3)
                {
                    ballCount = ballCount + 1;
                }

                if (guess2 == number2)
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess2 == number1 || guess2 == number3)
                {
                    ballCount = ballCount + 1;
                }

                if (guess3 == number3)
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess3 == number1 || guess3 == number2)
                {
                    ballCount = ballCount + 1;
                }

                Console.Write("스트라이크: ");
                Console.WriteLine(strikeCount);
                Console.Write("볼: ");
                Console.WriteLine(ballCount);
                Console.Write("아웃: ");
                Console.WriteLine(3 - strikeCount - ballCount);
            }
        }
    }
}
