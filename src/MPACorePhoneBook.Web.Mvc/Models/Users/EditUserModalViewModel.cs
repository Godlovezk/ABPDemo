using System.Collections.Generic;
using System.Linq;
using MPACorePhoneBook.Roles.Dto;
using MPACorePhoneBook.Users.Dto;

namespace MPACorePhoneBook.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
