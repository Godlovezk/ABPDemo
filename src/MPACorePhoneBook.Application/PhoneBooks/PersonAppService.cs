using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using MPACorePhoneBook.PhoneBooks.Dto;
using MPACorePhoneBook.PhoneBooks.Person;

namespace MPACorePhoneBook.PhoneBooks
{
    public class PersonAppService : MPACorePhoneBookAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Persons> _presonRepository;

        public Task CreatOrUpdatePersonAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeletePersonAsync(EntityDto input)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _presonRepository.GetAll();
            var personCount = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var dto = persons.MapTo<List<PersonListDto>>();

            return new PagedResultDto<PersonListDto>(personCount, dto);
        }

        public Task<PersonListDto> GetPersonByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
