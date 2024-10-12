using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Solstice.Database.Conventions.Helpers;

namespace Solstice.Database.Conventions.NamingConventions;

public class SnakeCaseNamingConvention : IModelFinalizingConvention 
{
    public void ProcessModelFinalizing(IConventionModelBuilder modelBuilder, IConventionContext<IConventionModelBuilder> context)
    {
        foreach (var entityType in modelBuilder.Metadata.GetEntityTypes())
        {
            // Apply naming convention to table name
            var originalTableName = entityType.GetTableName();
            var newTableName = SnakeCaseHelper.Convert(originalTableName);
            entityType.SetTableName(newTableName);

            foreach (var property in entityType.GetProperties())
            {
                // Apply naming convention to column names
                var originalColumnName = property.GetColumnName();
                var newColumnName = SnakeCaseHelper.Convert(originalColumnName);
                property.SetColumnName(newColumnName);
            }
        }
    }
}