using FluentValidation;
using FluentValidation.AspNetCore;
using Ibrahim.Web.Models.VM;
using Ibrahim.Web.Validators;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ibrahim.Web.MvcMiddlewares
{
    public static class FluentValidationExtensions
    {
        public static IServiceCollection AddFluentValidators(this IServiceCollection services)
        {
            return
                services
                    .AddFluentValidation()
                    .AddTransient<IValidator<CategoryVM>, CategoryValidator>();
        }
    }
}
