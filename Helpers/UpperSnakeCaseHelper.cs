using System.Text.RegularExpressions;

namespace Radiant.NET.Database.Conventions.Helpers;

public class UpperSnakeCaseHelper: ICaseHelper
{
    public static string Convert(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        var startUnderscores = Regex.Match(input, @"^_+");
        return startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToUpper();
    }
}