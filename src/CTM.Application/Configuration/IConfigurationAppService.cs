using System.Threading.Tasks;
using CTM.Configuration.Dto;

namespace CTM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
