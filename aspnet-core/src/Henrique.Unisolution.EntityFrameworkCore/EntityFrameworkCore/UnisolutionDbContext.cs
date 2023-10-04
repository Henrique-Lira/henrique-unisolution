using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Henrique.Unisolution.Authorization.Roles;
using Henrique.Unisolution.Authorization.Users;
using Henrique.Unisolution.MultiTenancy;

namespace Henrique.Unisolution.EntityFrameworkCore
{
    public class UnisolutionDbContext : AbpZeroDbContext<Tenant, Role, User, UnisolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public UnisolutionDbContext(DbContextOptions<UnisolutionDbContext> options)
            : base(options)
        {
        }
    }
}
