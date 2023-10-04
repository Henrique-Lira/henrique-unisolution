using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Henrique.Unisolution.Configuration;
using Henrique.Unisolution.Web;

namespace Henrique.Unisolution.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class UnisolutionDbContextFactory : IDesignTimeDbContextFactory<UnisolutionDbContext>
    {
        public UnisolutionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UnisolutionDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            UnisolutionDbContextConfigurer.Configure(builder, configuration.GetConnectionString(UnisolutionConsts.ConnectionStringName));

            return new UnisolutionDbContext(builder.Options);
        }
    }
}
