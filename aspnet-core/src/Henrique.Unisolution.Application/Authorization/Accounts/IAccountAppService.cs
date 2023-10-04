using System.Threading.Tasks;
using Abp.Application.Services;
using Henrique.Unisolution.Authorization.Accounts.Dto;

namespace Henrique.Unisolution.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
