using Abp.AutoMapper;
using Henrique.Unisolution.Authentication.External;

namespace Henrique.Unisolution.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
