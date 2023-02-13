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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    MovieTitle = "Black Panther: Wakanda Forever",
                    Category = "Action/Adventure",
                    Year = 2022,
                    Director = "Ryan Coogler",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieId = 2,
                    MovieTitle = "Puss in Boots: The Last Wish",
                    Category = "Adventure/Comedy",
                    Year = 2022,
                    Director = "Joel Crawford",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieId = 3,
                    MovieTitle = "A Man Called Otto",
                    Category = "Drama/Comedy",
                    Year = 2022,
                    Director = "Marc Forster",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            ) ;
        }
    }
}
