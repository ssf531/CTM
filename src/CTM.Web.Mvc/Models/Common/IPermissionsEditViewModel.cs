using System.Collections.Generic;
using CTM.Roles.Dto;

namespace CTM.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}