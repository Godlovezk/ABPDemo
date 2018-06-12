using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACorePhoneBook.MultiTenancy.Dto;

namespace MPACorePhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
