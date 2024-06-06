using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "Carry On jatta",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Comedy",
                    Price = 7.99M,
                    Rating ="R"
                },
                new Movie
                {
                    Title = "Wanted ",
                    ReleaseDate = DateTime.Parse("2010-3-13"),
                    Genre = "Action",
                    Price = 8.99M,
                    Rating ="R"
                },
                new Movie
                {
                    Title = "Stupid 2",
                    ReleaseDate = DateTime.Parse("1999-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating ="R"
                },
                new Movie
                {
                    Title = "Jatt and Julliet",
                    ReleaseDate = DateTime.Parse("2000-4-15"),
                    Genre = "Comedy",
                    Price = 3.99M,
                    Rating ="R"
                },
                new Movie
                {
                    Title = "Jatt and Julliet 2",
                    ReleaseDate = DateTime.Parse("2010-4-17"),
                    Genre = "Comedy",
                    Price = 3.97M,
                    Rating ="R"
                }
            );
            context.SaveChanges();
        }
    }
}
