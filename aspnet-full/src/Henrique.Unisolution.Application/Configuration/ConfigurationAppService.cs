using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Henrique.Unisolution.Configuration.Dto;

namespace Henrique.Unisolution.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : UnisolutionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
