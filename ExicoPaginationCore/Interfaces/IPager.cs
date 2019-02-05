using Microsoft.AspNetCore.Html;
using System.Collections.Generic;

namespace ExicoPaginationCore
{
    public interface IPager
    {        
        //IPagingConfig Config { get; }
        IPagingState State { get;  }
        IHtmlContent RenderPagination( int total, int perPage, IPagingConfig config);
    }
}
