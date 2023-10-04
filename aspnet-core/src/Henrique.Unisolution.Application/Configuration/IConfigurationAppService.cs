using System.Threading.Tasks;
using Henrique.Unisolution.Configuration.Dto;

namespace Henrique.Unisolution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
