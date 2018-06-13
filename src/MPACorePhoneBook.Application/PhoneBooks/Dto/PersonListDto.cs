using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MPACorePhoneBook.PhoneBooks.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace MPACorePhoneBook.PhoneBooks.Dto
{
    [AutoMapFrom(typeof(Persons))]   //表示从Person映射到PersonListDto
    public class PersonListDto:FullAuditedEntityDto
    {

        
        public string Name { get; set; }

        
        public string EmailAddress { get; set; }

      
        public string Address { get; set; }
    }
}
