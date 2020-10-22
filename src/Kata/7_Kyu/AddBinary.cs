namespace Kata._7_Kyu
{
    using System;

    /// <summary>
    /// Вернуть сумму двух чисел в двоичном формате
    /// </summary>
    public static class AddBinary
    {
        public static string Test(int a, int b)
        {
            var sum = a + b;

            return Convert.ToString(sum, 2);
        }
    }
}