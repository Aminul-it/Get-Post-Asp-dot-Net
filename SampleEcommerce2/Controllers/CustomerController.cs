using Microsoft.AspNetCore.Mvc;
using SampleEcommerce2.Models;

namespace SampleEcommerce2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(CreateVM model)
        { 

            return View(model);
        }
        public IActionResult Details(CustomerDetailsVM customerDetailsVM)
        {
            

            return View(customerDetailsVM);
        }
        public IActionResult Customerlist(List<CustomerDetailsVM> Customers)
        {
            return View(Customers);
        }


    }
}
