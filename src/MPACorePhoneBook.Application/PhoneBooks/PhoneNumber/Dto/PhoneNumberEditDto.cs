using Abp.AutoMapper;
using MPACorePhoneBook.PhoneBooks.Dto;
using MPACorePhoneBook.PhoneBooks.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACorePhoneBook.PhoneBooks.PhoneNumber.Dto
{
    [AutoMapTo(typeof(PhoneNumbers))]
    public class PhoneNumberEditDto
    {
        /// <summary>
        /// 号码
        /// </summary>
        [Required]
        [MaxLength(MPACorePhoneBookConsts.MaxPhoneLength)]
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneNumberType PhoneType { get; set; }

    }
}
