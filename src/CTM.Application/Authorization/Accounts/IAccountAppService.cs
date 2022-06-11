using System.Threading.Tasks;
using Abp.Application.Services;
using CTM.Authorization.Accounts.Dto;

namespace CTM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
