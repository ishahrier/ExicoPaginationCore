namespace ExicoPaginationCore
{
    /// <summary>
    /// For documentation on the configuration please 
    /// refer to the <see cref="IPagingConfig"/>
    /// </summary>
    public class DefaultPaginationConfig : IPagingConfig
    {
        public bool DoNotRenderForOnePage { get; set; } = true;
        public string PageKey { get; set; } = "page";
        public string LinkClass { get; set; } = "";
        public bool ShowNavigations { get; set; } = true;

        public string PaginationWrapperStart { get; set; } =
            $@"<nav aria-label='Page navigation '>
                <ul class='pagination'>";
        public string PaginationWrapperEnd { get; set; } = "</nav></ul>";
        public string LinkWrapperStart { get; set; } = "<li class='page-item'>";
        public string ActiveLinkWrapperStart { get; set; } = "<li class='page-item active'>";
        public string DisabledLinkWrapperStart { get; set; } = "<li class='page-item disabled'>";
        public string LinkWrapperEnd { get; set; } = "</li>";
        public string NextNavitionText { get; set; } = ">>";
        public string PrevNavitionText { get; set; } = "<<";
        public bool HideNextOnLastPage { get; set; } = false;
        public bool HidePrevOnFirstPage { get; set; } = false;
    }
}
