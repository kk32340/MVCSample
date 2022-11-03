using Microsoft.AspNetCore.Mvc;
using MVCSample.Models;
using System.Diagnostics;
using MVCSample.Models;

namespace MVCSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult LoadPartialView(string name)
        {

            var cust = new Customer()
            {
                name = name,
                phone = "phone1",
                CustAddresses = new List<Address>()
                {
                    {
                        new Address()
                        {
                            city="ciry1",
                            country="county1",
                            state="state1",
                            zipcode="zip1"

                        }

                    }
                }
            };

            return PartialView("_customer", cust);
        }

        public IActionResult Index()
        {

            var customers = new List<Customer>();

            customers.Add(new Customer()
            {
                name = "customer1",
                phone = "Phone1",
                CustAddresses = new List<Address>()
                {
                    {
                        new Address()
                        {
                            city = "ciry1",
                            country = "county1",
                            state = "state1",
                            zipcode = "zip1"

                        }

                    }
                }               


                 });


            customers.Add(new Customer()
            {
                name = "customer2",
                phone = "Phone1",
                CustAddresses = new List<Address>()
                {
                    {
                        new Address()
                        {
                            city = "ciry1",
                            country = "county1",
                            state = "state1",
                            zipcode = "zip1"

                        }

                    }
                }


            });


            return View(customers);
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
    }
}