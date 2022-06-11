using System.Threading.Tasks;
using Abp.Application.Services;
using CTM.Sessions.Dto;

namespace CTM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
