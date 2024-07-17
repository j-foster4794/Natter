using System.Threading.Tasks;
using Natter.Configuration.Dto;

namespace Natter.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
