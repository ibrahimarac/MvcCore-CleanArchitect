using Ibrahim.Core.Services;
using Ibrahim.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibrahim.Web.MvcMiddlewares
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            return
                services
                    .AddScoped<ICategoryService, CategoryService>()
                    .AddScoped<IErrorService, ErrorService>()
                    .AddScoped<ILogCrudService, LogCrudService>();
        }
    }
}
