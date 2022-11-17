using Microsoft.AspNetCore.Mvc;
using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        private List<Team> _teams = Data.Teams;
        public IActionResult Index()
        {
            return View(_teams);
        }

        public IActionResult Detail(int id)
        {
            Team team = _teams.Find(x => x.Id == id);

            return View(team);
        }
    }
}
