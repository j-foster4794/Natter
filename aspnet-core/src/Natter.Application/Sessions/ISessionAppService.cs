using System.Threading.Tasks;
using Abp.Application.Services;
using Natter.Sessions.Dto;

namespace Natter.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
