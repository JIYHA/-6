using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("six");
            int num;
            Console.WriteLine("Your number");
            num = int.Parse(Console.ReadLine());
            if (num >= 1000 || num <= 9999)
            {
                int firstDigit = num / 1000;
                int secondDigit = (num / 100) % 10;
                int thirdDigit = (num / 10) % 100 % 10;
                int fourthDigit = (num % 1000) % 100 % 10;
                Console.WriteLine("Итог: " + firstDigit * secondDigit * thirdDigit * fourthDigit);
                    }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
