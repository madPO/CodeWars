namespace Kata._6_Kyu
{
    public class IsValidWalk
    {
        public static bool Test(string[] walk)
        {
            const int maxTime = 10;

            if (walk.Length != maxTime)
                return false;
            
            var x = 0;
            var y = 0;

            foreach (var w in walk)
            {
                switch (w)
                {
                    case "n":
                        y++;
                        break;
                    case "s":
                        y--;
                        break;
                    case "w":
                        x++;
                        break;
                    case "e":
                        x--;
                        break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}