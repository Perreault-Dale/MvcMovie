using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The Singles Ward",
                         ReleaseDate = DateTime.Parse("1997-10-24"),
                         Genre = "Romantic Comedy",
                         Price = 7.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "The Home Teachers",
                         ReleaseDate = DateTime.Parse("1998-02-15"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "The RM",
                         ReleaseDate = DateTime.Parse("2001-04-27"),
                         Genre = "Comedy",
                         Price = 9.99M,
                         Rating = "PG"
                     },

                   new Movie
                   {
                       Title = "Church Ball",
                       ReleaseDate = DateTime.Parse("2003-11-17"),
                       Genre = "Comedy",
                       Price = 3.99M,
                       Rating = "PG"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}