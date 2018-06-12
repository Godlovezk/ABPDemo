using System.Collections.Generic;
using MPACorePhoneBook.Roles.Dto;

namespace MPACorePhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
