using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Henrique.Unisolution.Authorization.Users;
using Henrique.Unisolution.Editions;

namespace Henrique.Unisolution.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
