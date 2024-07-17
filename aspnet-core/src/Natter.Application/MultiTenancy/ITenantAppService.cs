using Abp.Application.Services;
using Natter.MultiTenancy.Dto;

namespace Natter.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

