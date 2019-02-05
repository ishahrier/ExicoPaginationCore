using System.Text;

namespace ExicoPaginationCore
{
    public class Link : ILink
    {
        //protected readonly IPagingConfig _Config;
        protected readonly IPagingState _State;

        public Link(IPagingState state/*, IPagingConfig config*/)
        {
            //_Config = config;
            _State = state;
        }

        public virtual bool IsNagivationLink => false;
        public string Text { get; set; }
        public int PageNum { get; set; }

        public virtual string Render(IPagingConfig config)
        {
            StringBuilder sb = new StringBuilder();
            var queryString = _State.BuildPaginationQueryString(config.PageKey, PageNum);
            sb.Append(_State.IsCurrentPage(PageNum) ? config.ActiveLinkWrapperStart : config.LinkWrapperStart);
            sb.Append($"<a id='page_link_{PageNum}'");
            sb.Append($" name='page_link_{PageNum}' ");
            sb.Append($" class='{config.LinkClass}' ");
            sb.Append($" href='{ (_State.IsCurrentPage(PageNum) ? "#" : "?" + queryString)}' ");
            sb.Append(">");
            sb.Append(Text ?? PageNum.ToString());
            sb.Append("</a>");
            sb.Append(config.LinkWrapperEnd);
            return sb.ToString();
        }
    }
}