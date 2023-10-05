using Abp.Application.Services;
using Henrique.Unisolution.MultiTenancy.Dto;

namespace Henrique.Unisolution.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

