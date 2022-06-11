using Abp.Authorization;
using CTM.Authorization.Roles;
using CTM.Authorization.Users;

namespace CTM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
