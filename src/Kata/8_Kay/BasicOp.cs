namespace Kata._8_Kay
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public class BasicOp
    {
        public static double Test(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;
            }

            return -1;
        }
    }
}