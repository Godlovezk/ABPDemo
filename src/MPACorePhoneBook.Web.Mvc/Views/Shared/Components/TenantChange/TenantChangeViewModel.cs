using Abp.AutoMapper;
using MPACorePhoneBook.Sessions.Dto;

namespace MPACorePhoneBook.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
