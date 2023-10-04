using System.Threading.Tasks;
using Abp.Application.Services;
using Henrique.Unisolution.Sessions.Dto;

namespace Henrique.Unisolution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
