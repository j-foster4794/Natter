using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Natter.Configuration.Dto;

namespace Natter.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NatterAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
