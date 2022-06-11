using System.Collections.Generic;
using CTM.Roles.Dto;

namespace CTM.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
