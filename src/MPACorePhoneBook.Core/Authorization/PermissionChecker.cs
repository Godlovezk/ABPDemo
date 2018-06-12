using Abp.Authorization;
using MPACorePhoneBook.Authorization.Roles;
using MPACorePhoneBook.Authorization.Users;

namespace MPACorePhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
