using System.Text.RegularExpressions;

namespace Game.Utils
{
    public class GameUtils
    {
        public static int ParseVersion(string version)
        {
            Regex reg = new Regex(@"\d+");
            string rawVersion = "0";
            var matches = reg.Matches(version);
            foreach (var m in matches)
            {
                rawVersion += m;
            }

            return int.Parse(rawVersion);
        }
    }
}