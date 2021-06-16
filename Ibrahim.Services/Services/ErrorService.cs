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
    public class ErrorService : IErrorService
    {
        private readonly IMapper Mapper;
        private readonly IUnitWork Database;

        public ErrorService(IMapper mapper,IUnitWork uWork)
        {
            Mapper = mapper;
            Database = uWork;
        }

        public void AddError(ErrorDto errorDto)
        {
            var error = Mapper.Map<ErrorDto, Error>(errorDto);
            Database.ErrorRepo.Insert(error);
            Database.Commit();
        }
    }
}
