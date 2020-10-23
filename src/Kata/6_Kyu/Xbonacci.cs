namespace Kata._6_Kyu
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Нужно посчитать последовательность Фибоначи, но на трех числах
    /// </summary>
    public class Xbonacci
    {
        public static double[] Test(double[] signature, int n)
        {
            // в случайных тестах может быть меньшее количество элементов
            // нормально если вернем только их
            if(signature.Length < 3)
                return signature;
    
            // в базовом тесте я получал n = 1 и ожидалось, что в ответе будет одно число
            if(n < 3)
                return signature.Take(n).ToArray();

            var elements = new List<double>(n);

            foreach (var element in signature.Take(3))
            {
                elements.Add(element);
            }
    
            void Recursive(int counter, double first, double second, double third)
            {
                if(counter <= 0)
                    return;

                var next = first + second + third;
        
                elements.Add(next);
        
                Recursive(--counter, second, third, next);
            }

            Recursive(n - 3, signature[0], signature[1], signature[2]);

            return elements.ToArray();
        }
    }
}