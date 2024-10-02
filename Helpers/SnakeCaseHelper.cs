using System.Text.RegularExpressions;

namespace Radiant.Database.Conventions.Helpers;

public class SnakeCaseHelper: ICaseHelper
{
    public static string Convert(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        var startUnderscores = Regex.Match(input, @"^_+");
        return startUnderscores + Regex.Replace(input, @"([a-zA-Z0-9])([A-Z])", "$1_$2").ToLower();
    }
}