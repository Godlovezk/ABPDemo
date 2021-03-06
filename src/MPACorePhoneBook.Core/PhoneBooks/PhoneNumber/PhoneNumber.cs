﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MPACorePhoneBook.PhoneBooks.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACorePhoneBook.PhoneBooks.PhoneNumber
{
    public class PhoneNumbers :Entity<long>, IHasCreationTime
    {
        /// <summary>
        /// 号码
        /// </summary>
        [Required]
        [MaxLength(11)]
        public string  Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneNumberType PhoneType { get; set; }

        public int PersonId { get; set; }

        public  Persons Person { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set ; }
    }
}
