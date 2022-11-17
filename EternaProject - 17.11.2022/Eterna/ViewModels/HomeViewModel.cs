using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Feature> Feature { get; set; }
        public List<Slide> Slider { get; set; }
        public List<Team> Teams { get; set; }
    }

}
