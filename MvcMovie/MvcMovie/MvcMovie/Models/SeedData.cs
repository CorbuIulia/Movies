using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Titanic",
                        ReleaseDate = DateTime.Parse("1990-7-12"),
                        Genre = "Romance",
                        Price = 10.1M
                    },

                    new Movie
                    {
                        Title = "Jurassic Park ",
                        ReleaseDate = DateTime.Parse("1993-6-9"),
                        Genre = "SF",
                        Price = 7M
                    },

                    new Movie
                    {
                        Title = "Ace Ventura",
                        ReleaseDate = DateTime.Parse("2001-2-23"),
                        Genre = "Comedy",
                        Price = 7M
                    },

                    new Movie
                    {
                        Title = "Joker",
                        ReleaseDate = DateTime.Parse("2018-4-15"),
                        Genre = "Drama",
                        Price = 8.99M
                    },
                    new Movie
                      {
                          Title = "Code 8",
                          ReleaseDate = DateTime.Parse("2019-8-10"),
                          Genre = "SF/Thriller",
                          Price = 9.99M
                      },
                     new Movie
                     {
                         Title = "Anna",
                         ReleaseDate = DateTime.Parse("2019-4-10"),
                         Genre = "Action",
                         Price = 11.2M
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
