using System.Collections.Generic;

namespace Eterna.Models
{
    public static class Data
    {
        public static List<Service> Services = new List<Service>()
            {
                new Service{Id = 1,Title = "Service 1",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 1", Icon="<i class=\"bx bxl-dribbble\"></i>"},
                new Service{Id = 2,Title = "Service 2",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 2", Icon="<i class=\"bx bx-file\"></i>"},
                new Service{Id = 3,Title = "Service 3",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 3", Icon="<i class=\"bx bx-tachometer\"></i>"},
                new Service{Id = 4,Title = "Service 4",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 4", Icon="<i class=\"bx bx-world\"></i>"},
                new Service{Id = 5,Title = "Service 5",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 5", Icon="<i class=\"bx bx-slideshow\"></i>"},
                new Service{Id = 6,Title = "Service 6",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 6", Icon="<i class=\"bx bx-arch\"></i>"},
            };
        public static List<Feature> Features = new List<Feature>()
        {
                new Feature{Id = 1,Title = "Service 1",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 1", Icon="<i class=\"bi bi-card-checklist\"></i>"},
                new Feature{Id = 2,Title = "Service 2",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 2", Icon="<i class=\"bi bi-bar-chart\"></i>"},
                new Feature{Id = 3,Title = "Service 3",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 3", Icon="<i class=\"bi bi-binoculars\"></i>"},
        };
        public static List<Slide> Slider = new List<Slide>()
        {
                new Slide{Id = 1,Title = "Service 1",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 1", Img="slide-1.jpg"},
                new Slide{Id = 2,Title = "Service 2",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 2", Img="slide-2.jpg"},
                new Slide{Id = 3,Title = "Service 3",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 3", Img="slide-3.jpg"},
        };

        public static List<Team> Teams = new List<Team>()
        {
                new Team{Id = 1, Image="team-1.jpg", FullName = "Walter White", Position = "Chief Executive Officer", Desc=" Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"},
                new Team{Id = 2, Image="team-2.jpg", FullName = "Sarah Jhinson", Position = "Product Manager", Desc="Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus"},
                new Team{Id = 3, Image="team-3.jpg", FullName = "William Anderson", Position = "CTO", Desc="Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara"},
        };
    }
}
