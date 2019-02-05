namespace ExicoPaginationCore
{
    public interface IPagingConfig
    {
        /// <summary>
        /// If there is only only page for the result set, then pagination 
        /// will not show is value is true, show otherwise.
        /// </summary>
        bool DoNotRenderForOnePage { get; set; }
        /// <summary>
        /// Page key is the key in querystring that contains the value of 
        /// the current page number.
        /// </summary>
        string PageKey { get; set; }
        /// <summary>
        /// Css class for each <a> tag 
        /// </summary>
        string LinkClass { get; set; }
        /// <summary>
        /// Show hide 'Prev' and 'Next' buttons
        /// </summary>
        bool ShowNavigations { get; set; } 
        /// <summary>
        /// You can customize the label for the Next navigation button here
        /// </summary>
        string NextNavitionText { get; set; }
        /// <summary>
        /// You can customize the label for the Prev navigation button here
        /// </summary>
        string PrevNavitionText { get; set; }
        /// <summary>
        /// Show/Hide the Next navigation button for the last page.
        /// NOTE: for the last page Next button is disabled (it shows but not clickable) anyways.
        /// </summary>        
        bool HideNextOnLastPage { get; set; }
        /// <summary>
        /// Show/Hide the Prev navigation button for the last page.
        /// NOTE: for the very first page Prev button is disabled (it shows but not clickable) anyways.
        /// </summary>        
        bool HidePrevOnFirstPage { get; set; }
        /// <summary>
        /// The wrapper element start for the entire pagination.
        /// i.e. <nav >
        /// </summary>
        string PaginationWrapperStart { get; set; }
        /// <summary>
        /// The wrapper element end for the entire pagination.
        /// i.e. </nav>
        /// </summary>
        string PaginationWrapperEnd { get; set; }
        /// <summary>
        /// The wrapper start element for the <a> tag.
        /// i.e. <li >
        /// </summary>
        string LinkWrapperStart { get; set; }
        /// <summary>
        /// The wrapper end element for the <a> tag.
        /// i.e. </li>
        /// </summary>
        string LinkWrapperEnd { get; set; }
        /// <summary>
        /// The wrapper start element for the active <a> tag.
        /// i.e. <li class='blah blah '>
        /// </summary>
        string ActiveLinkWrapperStart { get; set; }
        /// <summary>
        /// The wrapper start element for disabled <a> tag.
        /// i.e. <li class='blah blah disabled' >
        /// </summary>
        string DisabledLinkWrapperStart { get; set; }


    }
}