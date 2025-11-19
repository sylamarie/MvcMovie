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
            // If the Movie table already has data, stop.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "NR"
                },
                new Movie
                {
                    Title = "Lucy",
                    ReleaseDate = DateTime.Parse("2014-07-25"),
                    Genre = "Action",
                    Price = 10.99M,
                    Rating = "PG13"
                },
                new Movie
                {
                    Title = "Demon Slayer: To the Hashira Training",
                    ReleaseDate = DateTime.Parse("2024-02-02"),
                    Genre = "Anime",
                    Price = 12.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Last: Naruto the Movie",
                    ReleaseDate = DateTime.Parse("2014-12-06"),
                    Genre = "Anime",
                    Price = 8.99M,
                    Rating = "PG"
                }
            );
            context.SaveChanges();
        }
    }
}
