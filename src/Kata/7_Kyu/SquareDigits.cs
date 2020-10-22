namespace Kata._7_Kyu
{
    using System;

    /// <summary>
    /// Нужно вернуть число, которое будет собрано из квадратов цифр входящего числа
    /// </summary>
    public static class SquareDigits
    {
        public static int Test(int n)
        {
            const int basis = 10;
            n = Math.Abs(n);

            int SquareRecursion(int number)
            {
                if (number < basis)
                    return number * number;
                
                var digit = number % basis;
                var balance = number / basis;
                var square = digit * digit;

                var result = SquareRecursion(balance);

                var count = basis;
                
                while (count < square)
                {
                    count *= basis;
                }

                return result * count + square;
            }

            return SquareRecursion(n);
        }
    }
}