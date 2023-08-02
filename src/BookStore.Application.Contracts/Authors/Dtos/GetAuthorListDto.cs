using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BookStore.Authors.Dtos
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
