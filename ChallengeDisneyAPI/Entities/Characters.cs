using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisneyAPI.Entities
{
    public class Characters
    {
        public int Id { get;set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public string History { get; set; }

        //TODO : movie
        public ICollection<Movie> Movies { get; set; }


    }
}
