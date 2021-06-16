using Ibrahim.Core.Domain.Dto;
using Ibrahim.Core.Loggers;
using Ibrahim.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Utils.Loggers
{
    public class DbExceptionLogger:IExceptionLogger
    {
        private readonly IErrorService _errorService;

        public DbExceptionLogger(IErrorService errorService)
        {
            _errorService = errorService;
        }

        public void LogException(ErrorDto error)
        {
            _errorService.AddError(error);
        }

        
    }
}
