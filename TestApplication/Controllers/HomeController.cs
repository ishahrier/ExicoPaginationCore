using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TestApplication.Controllers
{
    public class SearchOptions
    {
        public int page { get; set; }
        public int GreaterThan {get;set;}

    }

    public class Employee
    {
        public int Age;
        public string Name;
    }



    public class HomeController : Controller
    {
        private List<Employee> Employees = new List<Employee>();
        private readonly int ItemsPerPage = 20;

        public HomeController()
        {
            BuildDatabase(21);
        }

        private void BuildDatabase(int toalRecords)
        {
            for (int i = 1; i <= toalRecords; i++)
            {
                Employees.Add(new Employee()
                {
                    Name = "Name " + i,
                    Age = i
                });
            }
        }

        public IActionResult Index([FromQuery]SearchOptions options)
        {
            List<Employee> result = new List<Employee>();
            result = Employees.Where(x => x.Age > options.GreaterThan)
                                 .Skip(((options.page==0 ? 1 : options.page)-1) * ItemsPerPage)
                                 .Take(ItemsPerPage)
                                 .ToList();
            int totalCount = Employees.Where(x => x.Age > options.GreaterThan)
                                      .Count();

            ViewBag.Result = result;            
            ViewBag.TotalCount = totalCount;
            ViewBag.ItemsPerPage = ItemsPerPage;


            return View(result);
        }

    }
}
