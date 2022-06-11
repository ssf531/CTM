using Abp.Application.Services;
using CTM.MultiTenancy.Dto;

namespace CTM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

