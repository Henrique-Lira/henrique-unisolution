using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Henrique.Unisolution.EntityFrameworkCore
{
    public static class UnisolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UnisolutionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UnisolutionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
