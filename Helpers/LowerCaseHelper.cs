using System.Text.RegularExpressions;

namespace Solstice.Database.Conventions.Helpers;

public class LowerCaseHelper: ICaseHelper
{
    public static string Convert(string input)
    {
        return string.IsNullOrEmpty(input) ? input : input.ToLower();
    }
}