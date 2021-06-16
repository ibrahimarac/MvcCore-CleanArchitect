using Ibrahim.Core.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Loggers
{
    public interface IExceptionLogger
    {
        void LogException(ErrorDto error);
    }
}
