using System.Collections.Generic;
using CTM.Roles.Dto;

namespace CTM.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
