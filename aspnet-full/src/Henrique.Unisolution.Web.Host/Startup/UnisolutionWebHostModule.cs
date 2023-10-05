using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Henrique.Unisolution.Configuration;
using Microsoft.Extensions.Hosting;

namespace Henrique.Unisolution.Web.Host.Startup
{
    [DependsOn(
       typeof(UnisolutionWebCoreModule))]
    public class UnisolutionWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public UnisolutionWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UnisolutionWebHostModule).GetAssembly());
        }
    }
}
