namespace Kata._6_Kyu
{
    using System.Linq;

    /// <summary>
    /// Найти число, которое повторяется нечетное количество раз
    /// </summary>
    public class FindOdd
    {
        public static int Test(int[] seq)
        {
            return seq.GroupBy(x => x)
                .Select(x => new { Count = x.Count(), Value = x.Key })
                .FirstOrDefault(x => x.Count % 2 != 0)
                .Value;
        }
    }
}