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
        public DbSet<Category> Categories { get; set; }

        // Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
                );

            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    MovieTitle = "Black Panther: Wakanda Forever",
                    CategoryID = 1,
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
                    CategoryID = 2,
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
                    CategoryID = 3,
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
