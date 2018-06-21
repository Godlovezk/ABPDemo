using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MPACorePhoneBook.PhoneBooks.Person;
using MPACorePhoneBook.PhoneBooks.PhoneNumber.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACorePhoneBook.PhoneBooks.Dto
{
    [AutoMapTo(typeof(Persons))]
    public class PersonEditDto
    {
        public int? Id  { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(80)]
        public string EmailAddress { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public List<PhoneNumberEditDto> PhoneNumbers { get; set; }
    }
}
