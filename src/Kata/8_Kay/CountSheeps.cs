namespace Kata._8_Kay
{
    using System.Linq;

    /// <summary>
    /// Подсчитать количество "овец" на месте
    /// </summary>
    public static class CountSheeps
    {
        public static int Test(bool[] sheeps)
        {
            if (sheeps == null)
                return 0;
            
            return sheeps.Count(x => x);
        }
    }
}