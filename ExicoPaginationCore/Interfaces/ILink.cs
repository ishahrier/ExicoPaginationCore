using Microsoft.AspNetCore.Http;
using System.Collections;

namespace ExicoPaginationCore
{
    public interface ILink
    {
        
        string Text { get; set; }
        int PageNum { get; set; }
        bool IsNagivationLink { get;  }                
        string Render( IPagingConfig config);
    }
}