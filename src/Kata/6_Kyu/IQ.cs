namespace Kata._6_Kyu
{
    using System;

    public static class IQ
    {
        /// <summary>
        /// Требуется вернуть позицию (начиная с 1) первого отличного по четности числа
        /// </summary>
        public static int Test(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            
            var evenCount = 0;
            var evenIndex = -1;
            var oddCount = 0;
            var oddIndex = -1;
            var elements = numbers.Split(" ");
            
            for (int i = 0; i < elements.Length; i++)
            {
                var element = elements[i];
                var result = Int32.TryParse(element, out var number);

                if (!result)
                    return i + 1;

                if (number % 2 == 0)
                {
                    evenCount++;
                    evenIndex = i;
                }
                else
                {
                    oddCount++;
                    oddIndex = i;
                }
                
                // нет отличного, можно идти дальше
                if(evenCount == 0 || oddCount == 0)
                    continue;
                
                // одинаковое количество четных и не четных, пропускаем
                if(evenCount == oddCount)
                    continue;

                // как только чего-то станет больше, то нашли
                if (evenCount > oddCount)
                    return oddIndex + 1;
                
                if (oddCount > evenCount)
                    return evenIndex + 1;
            }

            // для всех крайних вариантов отличного числа нет
            return 0;
        }
    }
}