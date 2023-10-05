using Abp.Application.Services;

namespace Henrique.Unisolution.Tanks
{
    using Dto;

    public interface ITankAppService: IAsyncCrudAppService<TankDto, string, PagedTankResultRequestDto, CreateTankDto, TankDto>
    {

    }
}
