using System.Text.RegularExpressions;

namespace Radiant.NET.Database.Conventions.Helpers;

public class UpperCaseHelper: ICaseHelper
{
    public static string Convert(string input)
    {
        return string.IsNullOrEmpty(input) ? input : input.ToUpper();
    }
}