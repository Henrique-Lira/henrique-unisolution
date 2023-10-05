using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;

namespace Henrique.Unisolution.EntityFrameworkCore
{
    using Authorization.Roles;
    using Authorization.Users;
    using MultiTenancy;
    using Tanks;
    public class UnisolutionDbContext : AbpZeroDbContext<Tenant, Role, User, UnisolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<Tank> Tanks { get; set; }

        public UnisolutionDbContext(DbContextOptions<UnisolutionDbContext> options)
            : base(options)
        {
        }
    }
}
