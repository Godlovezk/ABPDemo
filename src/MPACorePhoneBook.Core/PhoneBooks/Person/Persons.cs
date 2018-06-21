using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MPACorePhoneBook.PhoneBooks.PhoneNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACorePhoneBook.PhoneBooks.Person
{
   public  class Persons:FullAuditedEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(80)]
        public string  EmailAddress { get; set; }

        [MaxLength(200)]
        public string  Address { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public ICollection<PhoneNumbers> phoneNumbers { get; set; }
    }
}
