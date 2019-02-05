namespace ExicoPaginationCore
{
    public interface IPagingConfig
    {
        bool DoNotRenderForOnePage { get; set; }
        string PageKey { get; set; }
        string LinkClass { get; set; }
        bool ShowNavigations { get; set; } //next prev
        string NextNavitionText { get; set; }
        string PrevNavitionText { get; set; }
        bool HideNextOnLastPage { get; set; }
        bool HidePrevOnFirstPage { get; set; }

        string PaginationWrapperStart { get; set; }
        string PaginationWrapperEnd { get; set; }

        string LinkWrapperStart { get; set; }
        string LinkWrapperEnd { get; set; }
        string ActiveLinkWrapperStart { get; set; }
        string DisabledLinkWrapperStart { get; set; }


    }
}