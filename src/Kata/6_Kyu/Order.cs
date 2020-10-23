namespace Kata._6_Kyu
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// В каждом слове есть число от 1 до 9, которое означает позицию слова
    /// Нужно вернуть слова в правильной позиции
    /// </summary>
    public class Order
    {
        public static string Test(string words)
        {
            if (string.IsNullOrEmpty(words))
                return words;
            
            var regex = new Regex(@"(?<word>\w*(?<position>\d{1})\w*)\s?");
            var matches = regex.Matches(words);
            return string.Join(" ",matches
                .Select(x => new
                {
                    Value = x.Groups["word"].Value,
                    Position = Int32.Parse(x.Groups["position"].Value)
                })
                .OrderBy(x => x.Position)
                .Select(x => x.Value));
        }
    }
}