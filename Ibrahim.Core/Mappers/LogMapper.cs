using AutoMapper;
using Ibrahim.Core.Domain.Dto;
using Ibrahim.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Mappers
{
    public class LogMapper:Profile
    {
        public LogMapper()
        {
            //Entity To Dto
            CreateMap<Log, LogDto>();

            //Dto To Entity
            CreateMap<LogDto, Log>();
        }
    }
}
