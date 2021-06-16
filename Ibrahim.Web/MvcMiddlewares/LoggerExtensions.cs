using Ibrahim.Core.Loggers;
using Ibrahim.Core.Services;
using Ibrahim.Services.Services;
using Ibrahim.Utils.Loggers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibrahim.Web.MvcMiddlewares
{
    public static class LoggerExtensions
    {
        public static IServiceCollection AddLoggers(this IServiceCollection services)
        {
            return
                services
                    .AddScoped<IExceptionLogger, DbExceptionLogger>()
                    .AddScoped<ICrudOperationLogger, DbCrudOperationLogger>();
        }
    }
}
