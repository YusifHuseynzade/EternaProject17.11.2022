using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Services = Data.Services,
                Feature = Data.Features,
                Slider = Data.Slider,
        };
            return View(vm);
        }

    }
}
