using AutoMapper;
using Ibrahim.Core.Domain.Dto;
using Ibrahim.Core.Domain.Entities;
using Ibrahim.Core.Loggers;
using Ibrahim.Core.Repositories;
using Ibrahim.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Utils.Loggers
{
    public class DbCrudOperationLogger : ICrudOperationLogger
    {
        private readonly ICrudLoggerRepository _logCrudRepo;
        private readonly IMapper _mapper;

        public DbCrudOperationLogger(ICrudLoggerRepository logCrudRepo,IMapper mapper)
        {
            _logCrudRepo = logCrudRepo;
            _mapper = mapper;
        }

        public void LogCrudOperation(IEnumerable<LogDto> logs)
        {
            var logEntities = _mapper.Map<IEnumerable<LogDto>, IEnumerable<Log>>(logs);
            _logCrudRepo.Insert(logEntities);
        }
    }
}
