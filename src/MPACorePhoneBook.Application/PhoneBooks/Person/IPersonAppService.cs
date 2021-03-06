﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACorePhoneBook.PhoneBooks.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MPACorePhoneBook.PhoneBooks
{
    public  interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 获取联系人的相关信息,支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput  input);

        /// <summary>
        /// 根据ID获取联系人的相关信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);

        /// <summary>
        /// 通过id获取联系人的信息进行编辑
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetPersonForEditOutPut> GetPersonForEditAsync(NullableIdDto input);

        /// <summary>
        /// 新增或者更改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreatOrUpdatePersonAsync( CreateOrUpdatePersonInput input);
        /// <summary>
        /// 删除联系人信息
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);
    }
}
