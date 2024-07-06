using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Radiant.NET.Database.Conventions.Helpers;

namespace Radiant.NET.Database.Conventions.NamingConventions;

public class LowerCaseNamingConvention : IModelFinalizingConvention 
{
    public void ProcessModelFinalizing(IConventionModelBuilder modelBuilder, IConventionContext<IConventionModelBuilder> context)
    {
        foreach (var entityType in modelBuilder.Metadata.GetEntityTypes())
        {
            // Apply naming convention to table name
            var originalTableName = entityType.GetTableName();
            var newTableName = LowerCaseHelper.Convert(originalTableName);
            entityType.SetTableName(newTableName);

            foreach (var property in entityType.GetProperties())
            {
                // Apply naming convention to column names
                var originalColumnName = property.GetColumnName();
                var newColumnName = LowerCaseHelper.Convert(originalColumnName);
                property.SetColumnName(newColumnName);
            }
        }
    }
}