using Microsoft.AspNetCore.Html;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExicoPaginationCore
{
    public class Pager : IPager
    {
        //private readonly IPagingConfig _Config;
        private readonly IServiceProvider _Services;
        private readonly IPagingState _State;
        public Pager(IServiceProvider services, IPagingState state)
        {
            //_Config = config;
            _State = state;
            _Services = services;
        }

        //public IPagingConfig Config => _Config;

        public int ItemsPerPage { get; set; }

        public IPagingState State => _State;

        public int TotalItems { get; set; }

        public int TotalPages => (TotalItems / ItemsPerPage) + ((TotalItems % ItemsPerPage) > 0 ? 1 : 0);

        public IHtmlContent RenderPagination(int total, int perPage,IPagingConfig config)
        {
            TotalItems = total;
            ItemsPerPage = perPage;
            StringBuilder sb = new StringBuilder();
            sb.Append(config.PaginationWrapperStart);
            _GenerateLinks(_State.CurrentPage,config).ForEach(x => sb.Append(x.Render(config)));
            sb.Append(config.PaginationWrapperEnd);
            return new HtmlString(sb.ToString());
        }

        private List<ILink> _GenerateLinks(int currentPage,IPagingConfig config)
        {
            List<ILink> pages = new List<ILink>();
            if (config.ShowNavigations)
            {
                if (!(config.HidePrevOnFirstPage && currentPage == 1))
                {
                    var link = _Services.GetService<IPrevLink>();
                    link.PageNum = currentPage - 1 <= 0 ? 0 : currentPage - 1;
                    pages.Add(link);
                }
            }

            for (int i = 0; i < TotalPages; i++)
            {
                var link = _Services.GetService<ILink>();
                link.PageNum = i + 1;
                pages.Add(link);
            }
            if (config.ShowNavigations)
            {
                if (!(config.HideNextOnLastPage && currentPage == TotalPages))
                {
                    var link = _Services.GetService<INextLink>();
                    link.PageNum = currentPage == TotalPages ? 0 : currentPage + 1;
                    pages.Add(link);
                }
            }

            return pages;
        }
    }
}