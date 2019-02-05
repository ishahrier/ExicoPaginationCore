namespace ExicoPaginationCore
{
    public class PrevLink : NavLink, IPrevLink
    {
        public PrevLink(IPagingState state) : base(state)
        {

        }

        public override string Render(IPagingConfig config)
        {
            this.Text = config.PrevNavitionText;
            return base.Render(config);
        }
    }
}