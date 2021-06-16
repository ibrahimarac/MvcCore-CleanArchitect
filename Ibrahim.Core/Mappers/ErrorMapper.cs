using AutoMapper;
using Ibrahim.Core.Domain.Dto;
using Ibrahim.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Mappers
{
    public class ErrorMapper:Profile
    {
        public ErrorMapper()
        {
            CreateMap<Error, ErrorDto>();
            CreateMap<ErrorDto, Error>();
        }
    }
}
