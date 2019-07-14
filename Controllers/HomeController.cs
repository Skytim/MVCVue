namespace MVCVue.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using MVCVue.Models;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("[action]")]
        public IActionResult SampleData()
        {
            var result = new List<PersonModel>();

            result.Add(new PersonModel
            {
                Age = 28,
                FirstName = "Tim",
                LastName = "Tsai"
            });

            result.Add(new PersonModel
            {
                Age = 21,
                FirstName = "Larsen",
                LastName = "Shaw"
            });

            result.Add(new PersonModel
            {
                Age = 89,
                FirstName = "Geneva",
                LastName = "Wilson"
            });

            result.Add(new PersonModel
            {
                Age = 28,
                FirstName = "Jami",
                LastName = "Carney"
            });

            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult PersonData([FromBody]PersonDataModel data)
        {
            return Ok();
        }
    }
}
