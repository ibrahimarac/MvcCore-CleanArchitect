using Ibrahim.Core.Repositories;
using Ibrahim.Data.Sql.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibrahim.Web.MvcMiddlewares
{
    public static class RepositoryInjections
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return
                services
                    .AddScoped<ICategoryRepository, CategoryRepository>()
                    .AddScoped<IErrorRepository, ErrorRepository>()
                    .AddScoped<ICrudLoggerRepository, CrudLoggerRepository>();
        }
    }
}
