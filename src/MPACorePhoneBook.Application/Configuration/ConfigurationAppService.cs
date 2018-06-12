using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MPACorePhoneBook.Configuration.Dto;

namespace MPACorePhoneBook.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MPACorePhoneBookAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
