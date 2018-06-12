using System.Threading.Tasks;
using MPACorePhoneBook.Configuration.Dto;

namespace MPACorePhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
