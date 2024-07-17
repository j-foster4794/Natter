using System.Threading.Tasks;
using Abp.Application.Services;
using Natter.Authorization.Accounts.Dto;

namespace Natter.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
