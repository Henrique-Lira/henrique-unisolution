using Abp.MultiTenancy;
using Henrique.Unisolution.Authorization.Users;

namespace Henrique.Unisolution.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
