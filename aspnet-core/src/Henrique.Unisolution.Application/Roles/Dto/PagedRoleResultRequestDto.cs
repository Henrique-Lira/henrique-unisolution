using Abp.Application.Services.Dto;

namespace Henrique.Unisolution.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

