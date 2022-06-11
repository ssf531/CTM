using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CTM.Configuration.Dto;

namespace CTM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CTMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
