using Microsoft.EntityFrameworkCore;
using Solstice.Database.Conventions.NamingConventions;

namespace Solstice.Database.Conventions.Injections;

public static class ConventionsInjections
{
    public static void ToSnakeCase(this ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new SnakeCaseNamingConvention());
    }
    
    public static void ToUpperCase(this ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new UpperCaseNamingConvention());
    }
    
    public static void ToLowerCase(this ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new LowerCaseNamingConvention());
    }
    
    public static void ToUpperSnakeCase(this ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new UpperSnakeCaseNamingConvention());
    }
}