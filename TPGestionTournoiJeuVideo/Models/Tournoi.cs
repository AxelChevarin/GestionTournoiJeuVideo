using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPGestionTournoiJeuVideo.Models
{
    public class Tournoi
    {

        public int id { get; set; }
        public string Name { get; set; }

        public int Prix { get; set; }
        public string Description{ get; set; }

        public string Date { get; set; }
        public string Jeu{ get; set; }
        public string Theme { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
