using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Henrique.Unisolution.Roles.Dto;
using Henrique.Unisolution.Users.Dto;

namespace Henrique.Unisolution.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
