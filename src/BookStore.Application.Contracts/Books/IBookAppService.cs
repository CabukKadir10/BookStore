﻿using BookStore.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BookStore.Books
{
    public interface IBookAppService :
    ICrudAppService< 
        BookDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateBookDto> 
    {
        Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
    }
}
