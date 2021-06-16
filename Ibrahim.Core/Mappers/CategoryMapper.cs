using AutoMapper;
using Ibrahim.Core.Domain.Dto;
using Ibrahim.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Mappers
{
    public class CategoryMapper:Profile
    {
        public CategoryMapper()
        {
            //Entity To Dto
            CreateMap<Category, CategoryDto>();

            //Dto to Entity
            CreateMap<CategoryDto, Category>();
        }
    }
}
