using Abp;
using Abp.Runtime.Validation;
using MPACorePhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MPACorePhoneBook.PhoneBooks.Dto
{
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string FilterText { get; set; }
        //Viewmodel=>dto=>model
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
