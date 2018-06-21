using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACorePhoneBook.PhoneBooks.PhoneNumber.Dto
{
    [AutoMapTo(typeof(PhoneNumbers))]
    public  class PhoneNumberListDto
    {
        /// <summary>
        /// 号码
        /// </summary>
     
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneType PhoneType { get; set; }
    }
}
