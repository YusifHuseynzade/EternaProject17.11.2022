using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {
        private List<Service> _services = Data.Services;
        public IActionResult Index()
        {
            return View(_services);
        }

        public IActionResult Detail(int id)
        {
            Service service = _services.Find(x => x.Id == id);

            return View(service);
        }
    }
}
