using Abp.Authorization;
using Henrique.Unisolution.Authorization.Roles;
using Henrique.Unisolution.Authorization.Users;

namespace Henrique.Unisolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
