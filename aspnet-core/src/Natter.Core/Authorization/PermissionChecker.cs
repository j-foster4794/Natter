using Abp.Authorization;
using Natter.Authorization.Roles;
using Natter.Authorization.Users;

namespace Natter.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
