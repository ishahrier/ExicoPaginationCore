## ExicoPaginationCore
A pagination for aspnet core applications. Easily create paginations for your tabular/list data display pages. By default the styling is done assuming that you are using bootstrap. But everything can be overridden and customized.

## How to use

1. In your **Startup.cs** add the pagination

   ```c#
   public void ConfigureServices(IServiceCollection services)
   {
   	services.AddExicoCorePagination();
   }
   ```

2. Now import the namespace in your **_ViewImports.cshtml** by adding this following line

   `@using ExicoPaginationCore` 

3. Then in your view file use this extension method to render pagination

   ` @Html.RenderPagination()` 

   This method takes three parameters i.e.

   ```c#
   @Html.RenderPagination((int)ViewBag.TotalCount, (int)ViewBag.ItemsPerPage, config)
   ```

   1. Total result count

   2. Items per page 

   3. And lastly **IPagingConfig** instance

      Note that,  **IPagingConfig** can be injected and directly used (as the example above is using)

      `@inject IPagingConfig config`

      This config object is an instance of the [DefaultPaginationConfig](https://github.com/ishahrier/ExicoPaginationCore/blob/master/ExicoPaginationCore/Implementations/DefaultPaginationConfig.cs) (uses bootstrap 4). 

      You can also create and object of  **DefaultPaginationConfig** , customize it and pass it as param.

      ```c#
      @Html.RenderPagination((int)ViewBag.TotalCount,(int)ViewBag.ItemsPerPage, new DefaultPaginationConfig()
      {
      HideNextOnLastPage = true,
      HidePrevOnFirstPage = true
      });
      ```

      or you can create an entirely new implementation of **IPagingConfig**  and replace the default service registration.




There is a fully working demo project included , check it out [TestApplication.csproj](https://github.co!m/ishahrier/ExicoPaginationCore/tree/master/TestApplication) !

![screenshot](https://github.com/ishahrier/ExicoPaginationCore/raw/master/screenshot.png)
