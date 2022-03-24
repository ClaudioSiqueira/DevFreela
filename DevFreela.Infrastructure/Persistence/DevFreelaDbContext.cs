using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Meu projeto ASP NET Core 1", "Minha descrição 1", 1, 1, 10000),
                new Project("Meu projeto ASP NET Core 2", "Minha descrição 2", 1, 1, 20000),
                new Project("Meu projeto ASP NET Core 3", "Minha descrição 3", 1, 1, 30000)
            };

            Users = new List<User>()
            {
                new User("Claudio Siqueira", "crsjunior2001@gmail.com", new DateTime(2001, 7, 17)),
                new User("Jeniffer Nathalia", "jenathpaiva@gmail.com", new DateTime(2000, 12, 11)),
                new User("Pedro Silva", "pedrosilva@gmail.com", new DateTime(2002, 3, 27)),
            };

            Skills = new List<Skill>()
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
