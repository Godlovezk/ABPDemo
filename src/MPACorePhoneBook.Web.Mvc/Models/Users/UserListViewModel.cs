using System.Collections.Generic;
using MPACorePhoneBook.Roles.Dto;
using MPACorePhoneBook.Users.Dto;

namespace MPACorePhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
