using Microsoft.EntityFrameworkCore;
using Solstice.Database.Conventions.NamingConventions;

namespace Solstice.Database.Conventions.Injections;

public class ConventionsInjections
{
    public static void ToSnakeCase(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new SnakeCaseNamingConvention());
    }
    
    public static void ToUpperCase(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new UpperCaseNamingConvention());
    }
    
    public static void ToLowerCase(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new LowerCaseNamingConvention());
    }
    
    public static void ToUpperSnakeCase(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new UpperSnakeCaseNamingConvention());
    }
}