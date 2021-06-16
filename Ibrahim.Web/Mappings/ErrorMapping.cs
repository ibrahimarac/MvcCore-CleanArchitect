using AutoMapper;
using Ibrahim.Core.Domain.Dto;
using Ibrahim.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibrahim.Web.Mappings
{
    public class ErrorMapping:Profile
    {
        public ErrorMapping()
        {
            CreateMap<ErrorDto, ErrorVM>();
            CreateMap<ErrorVM, ErrorDto>();
        }
    }
}
