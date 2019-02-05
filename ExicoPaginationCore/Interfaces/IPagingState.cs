using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExicoPaginationCore
{
    public interface IPagingState
    {
        IHttpContextAccessor ContextAccessor { get; }
        int CurrentPage { get;   }
        IQueryCollection Query { get; }
        bool IsCurrentPage(int pageNum);
        string GetQueryString( );
        string BuildPaginationQueryString(string pagingKey, int pageNum);
        bool KeyExists(string key);
    }
}