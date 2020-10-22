namespace Kata._7_Kyu
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Получить наибольшее число из цифр входящего числа
    /// </summary>
    public class DescendingOrder
    {
        public static int Test(int num)
        {
            const int basis = 10;
            
            if (num == 0)
                return 0;
            
            num = Math.Abs(num);

            IEnumerable<int> ToDigit(int number)
            {
                while (number >= basis)
                {
                    var result = number % basis;
                    number = number / basis;
                    yield return result;
                }

                yield return number;
            }
            
            return ToDigit(num)
                .OrderBy(x => x)
                .Select((x, i) => x * (int)Math.Pow(basis, i))
                .Sum();
        }
    }
}