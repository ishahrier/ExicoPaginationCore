using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace ExicoPaginationCore
{
    public class PagingState : IPagingState
    {
        private readonly IHttpContextAccessor _ContextAccessor;
        private readonly IPagingConfig _Config;

        public PagingState(IPagingConfig config, IHttpContextAccessor contextAccessor)
        {
            _Config = config;
            _ContextAccessor = contextAccessor;
        }

        public IHttpContextAccessor ContextAccessor => _ContextAccessor;

        public int CurrentPage
        {
            get
            {
                if (Query.ContainsKey(_Config.PageKey))
                {
                    int page = 1;
                    Int32.TryParse(Query[_Config.PageKey].First(), out page);
                    return page;
                }
                else return 1;
            }

        }

        public bool IsCurrentPage(int pageNum) => CurrentPage == pageNum;

        public IQueryCollection Query => _ContextAccessor.HttpContext.Request.Query;

        public string BuildPaginationQueryString(string pagingKey, int pageNum)
        {
            var ret = string.Join('&', (from key in Query.Keys
                                        select $"{key}={ (pagingKey == key ? pageNum.ToString() : Query[key].First())}"));
            if (!KeyExists(pagingKey)) ret += $"&{pagingKey}={pageNum}";
            return ret;
        }

        public string GetQueryString() => _ContextAccessor.HttpContext.Request.QueryString.ToString();

        public bool KeyExists(string key) => Query.Keys.Contains(key);
    }
}
