using System.Threading.Tasks;
using Abp.Application.Services;
using MPACorePhoneBook.Sessions.Dto;

namespace MPACorePhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
