using System;

namespace Objective_2_2
{
//    Реализовать функцию возведения числа a в степень b:
//       a.Без рекурсии.
//       b.Рекурсивно.
//       c. *Рекурсивно, используя свойство чётности степени

    class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = 5;
            int power = 4;
            int aAnswer;
            int bAnswer;
            int cAnswer;

            aAnswer = AExpontiatation(initialNumber, power);
            Console.WriteLine($"a: {aAnswer}");                 // 625

            bAnswer = BExponential(initialNumber, power);
            Console.WriteLine($"b: {bAnswer}");                 // 625

            cAnswer = CExponential(initialNumber, power);
            Console.WriteLine($"c: {cAnswer}");                 // 625
            Console.Read();
        }

        static int AExpontiatation(int num, int pow)
        {
            int tempNum = num;
            for (int i = 0; i < pow-1; i++)
            {
                num *= tempNum;
            }
            return num;
        }

        static int BExponential(int num, int pow)
        {
            if(pow == 1)
            {
                return num;
            }
            else
            {
                return num *= BExponential(num, pow - 1);
            }

        }

        static int CExponential(int num, int pow)
        {
            int temp;
            if (pow == 0) return 1;
            else if (pow % 2 == 1) return CExponential(num, pow - 1) * num;
            else
            {
                temp = CExponential(num, pow / 2);
                return temp *= temp;
            }

        }
    }
}
