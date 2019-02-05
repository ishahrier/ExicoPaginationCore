namespace ExicoPaginationCore
{
    public class NextLink : NavLink, INextLink
    {
        public NextLink(IPagingState state) : base(state)
        {
        }
        public override string Render(IPagingConfig config)
        {
            this.Text = config.NextNavitionText;
            return base.Render(config);
        }
    }
}