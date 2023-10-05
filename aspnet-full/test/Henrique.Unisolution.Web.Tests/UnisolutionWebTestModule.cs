using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Henrique.Unisolution.EntityFrameworkCore;
using Henrique.Unisolution.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Henrique.Unisolution.Web.Tests
{
    [DependsOn(
        typeof(UnisolutionWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class UnisolutionWebTestModule : AbpModule
    {
        public UnisolutionWebTestModule(UnisolutionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UnisolutionWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(UnisolutionWebMvcModule).Assembly);
        }
    }
}