﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisneyAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        //todo : movie
        public ICollection<Movie> Movies { get; set; }

    }
}
