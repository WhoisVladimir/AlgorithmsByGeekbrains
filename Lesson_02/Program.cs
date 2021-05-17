using System;

namespace Objective_2_1
{
    // Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.

    class Program
    {
        static int index = 1;
        static int count = 1;

        static void Main(string[] args)
        {
             int initialDecimal = 19;
            int[] finalBinary;


            finalBinary = TranslateNumberSystem(initialDecimal);
            foreach (var item in finalBinary)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }

        static int[] TranslateNumberSystem(int dec)
        {
            int binNum;
            int[] arr;
            
            if (dec/2 <= 0)
            {
                binNum = 1;
                if (count > 0) arr = new int[count];
                else arr = new int[index];
                arr[index-1] = binNum;
                return arr;
            }
            else
            {
                binNum = dec % 2;
                count++;
                dec = dec / 2;
                arr = TranslateNumberSystem(dec);
                index++;
                arr[index - 1] = binNum;
                return arr;
            }
        }
    }
}
