using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Henrique.Unisolution.Authorization;

namespace Henrique.Unisolution
{
    [DependsOn(
        typeof(UnisolutionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UnisolutionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UnisolutionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UnisolutionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
