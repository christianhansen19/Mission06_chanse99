using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_chanse99.Models
{
    public class MovieCollectionContext : DbContext
    {   
        //Constructor
        public MovieCollectionContext (DbContextOptions<MovieCollectionContext> options) : base(options)
        {
            // Leave blank for now
        }
        
        public DbSet<MovieResponse> responses { get; set; }
    }
}
