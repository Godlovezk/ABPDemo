using System.Threading.Tasks;
using Abp.Application.Services;
using MPACorePhoneBook.Authorization.Accounts.Dto;

namespace MPACorePhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
