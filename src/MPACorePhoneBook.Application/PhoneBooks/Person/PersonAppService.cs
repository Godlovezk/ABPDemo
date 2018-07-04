using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using MPACorePhoneBook.PhoneBooks.Dto;
using MPACorePhoneBook.PhoneBooks.Person;

namespace MPACorePhoneBook.PhoneBooks
{
    public class PersonAppService : MPACorePhoneBookAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Persons> _presonRepository;

        public PersonAppService(IRepository<Persons> repository)
        {
            _presonRepository = repository;
        }

        public async Task CreatOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatPerson(input.PersonEditDto);
            }

            //throw new NotImplementedException();
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _presonRepository.GetAsync(input.Id);
            if (entity==null)
            {
                throw new UserFriendlyException("联系人已经被删除");
            }
            await _presonRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _presonRepository.GetAllIncluding(a => a.phoneNumbers);
            var personCount = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var dto = persons.MapTo<List<PersonListDto>>();

            return new PagedResultDto<PersonListDto>(personCount, dto);
        }


        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {

            Logger.Info("Creating a task for input:"+input);  //日志
            var person = await _presonRepository.GetAllIncluding(a => a.phoneNumbers).FirstOrDefaultAsync(a => a.Id == input.Id.Value);//   .GetAsync(input.Id.Value);
            return person.MapTo<PersonListDto>();
        }

        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _presonRepository.GetAsync(input.Id.Value);

            await _presonRepository.UpdateAsync(input.MapTo(entity));
        }

        protected async  Task CreatPerson(PersonEditDto input)
        {
            var entity = input.MapTo<Person.Persons>();

            //await   _presonRepository.InsertAsync(input.MapTo<Persons>());
            await _presonRepository.InsertAsync(entity);
        }

        public  async Task<GetPersonForEditOutPut> GetPersonForEditAsync(NullableIdDto input)
        {
            var output = new GetPersonForEditOutPut();
            PersonEditDto personEditDto;
            if (input .Id.HasValue)
            {
                var entity = await _presonRepository.GetAllIncluding(a => a.phoneNumbers).FirstOrDefaultAsync(a => a.Id == input.Id.Value); //.GetAsync(input.Id.Value);
                personEditDto = entity.MapTo<PersonEditDto>();
            }
            else
            {
                personEditDto = new PersonEditDto();
            }
            output.Person = personEditDto;
            return output;
        }

    }
}
