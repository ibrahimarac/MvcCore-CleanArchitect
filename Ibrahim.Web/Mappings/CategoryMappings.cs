using AutoMapper;
using Ibrahim.Core.Domain.Dto;
using Ibrahim.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibrahim.Web.Mappings
{
    public class CategoryMappings:Profile
    {
        public CategoryMappings()
        {
            CreateMap<CategoryDto, CategoryVM>();
            CreateMap<CategoryVM, CategoryDto>();
        }
    }
}
