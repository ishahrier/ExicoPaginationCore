using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExicoPaginationCore
{

    public static class PaginationInjector
    {
        public static void AddExicoCorePagination(this IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ILink,Link>();
            services.AddTransient<IPrevLink, PrevLink>();
            services.AddTransient<INextLink, NextLink>();
            services.AddTransient<IPagingConfig, DefaultPaginationConfig>();
            services.AddTransient<IPagingState, PagingState>();
            services.AddTransient<IPager, Pager>();
        }
    }
}

