﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nArchitecture.Persistence.Repositories
{
    public class Entity<TId>
    {
        public TId Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public DateTime DeletedAt { get; set;}


    }
}
