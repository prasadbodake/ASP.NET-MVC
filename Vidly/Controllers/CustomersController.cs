using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }


        public ActionResult Details(int id)
        {
            var customer = GetCustomers().FirstOrDefault(customer1 => Equals(customer1.Id, id));

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        private static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 123,
                    Name = "Kartikey Gupta"
                },
                new Customer
                {
                    Id = 789,
                    Name = "Mayank Soni"
                }
            };
        }
    }
}