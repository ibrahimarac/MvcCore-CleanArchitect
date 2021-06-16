using AutoMapper;
using Ibrahim.Core;
using Ibrahim.Core.Domain.Dto;
using Ibrahim.Core.Domain.Entities;
using Ibrahim.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Services.Services
{
    public class LogCrudService : ILogCrudService
    {
        private readonly IMapper Mapper;
        private readonly IUnitWork Database;

        public LogCrudService(IMapper mapper, IUnitWork uWork)
        {
            Mapper = mapper;
            Database = uWork;
        }

    }
}
