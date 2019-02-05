using System.Collections.Generic;
using System.Text;

namespace ExicoPaginationCore
{
    public abstract class NavLink : Link
    {
        public NavLink( IPagingState state) : base(state)
        {

        }
        public override bool IsNagivationLink => true;
        public virtual string Render(IPagingConfig config)
        {
            StringBuilder sb = new StringBuilder();            
            var qString = PageNum != 0 ? "?" + _State.BuildPaginationQueryString(config.PageKey, PageNum) : "#";
            sb.Append(PageNum == 0 ? config.DisabledLinkWrapperStart : config.LinkWrapperStart);
            sb.Append($"<a id='page_link_{PageNum}'");
            sb.Append($" name='page_link_{PageNum}' ");
            sb.Append($" class='{config.LinkClass}' ");
            sb.Append($" href='{ qString}' ");
            sb.Append(">");
            sb.Append(Text ?? PageNum.ToString());
            sb.Append("</a>");
            sb.Append(config.LinkWrapperEnd);
            return sb.ToString();
        }
    }
}
