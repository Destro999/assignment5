using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BooksDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BooksDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //seeding the database data of all 10 books
            if(!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Project
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = 978 - 0451419439,
                        Category = "Fiction, Classic",
                        Price = 9.95,
                        Pages = 1488,
                    },

                    new Project
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 978 - 0743270755,
                        Category = "Non-Fiction, Biography ",
                        Price = 14.58,
                        Pages = 944,
                    },

                    new Project
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = 978 - 0553384611,
                        Category = "Non-Fiction, Biography ",
                        Price = 21.54,
                        Pages = 832,
                    },

                    new Project
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = 978-0812981254,
                        Category = "Non-Fiction, Biography ",
                        Price = 11.61,
                        Pages = 864,
                    },

                    new Project
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 978-0812974492,
                        Category = "Non-Fiction, Historical ",
                        Price = 13.33,
                        Pages = 528,
                    },

                    new Project
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = 978-0804171281,
                        Category = "Fiction, Historical Fiction ",
                        Price = 15.95,
                        Pages = 288,
                    },

                    new Project
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 978-1455586691,
                        Category = "Non-Fiction, Self-Help ",
                        Price = 14.99,
                        Pages = 304,
                    },

                    new Project
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = 978-1455523023,
                        Category = "Non-Fiction, Self-Help ",
                        Price = 21.66,
                        Pages = 240,
                    },

                    new Project
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = 978-1591847984,
                        Category = "Non-Fiction, Business ",
                        Price = 29.16,
                        Pages = 400,
                    },

                    new Project
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = 978-0553393613,
                        Category = "Fiction, Thrillers",
                        Price = 15.03,
                        Pages = 642,
                    },

                    new Project
                    {
                        Title = "Fablehaven",
                        Author = "Brandon Mull",
                        Publisher = "Portfolio",
                        ISBN = 978 - 0553391546,
                        Category = "Fiction",
                        Price = 17.73,
                        Pages = 438,
                    },

                    new Project
                    {
                        Title = "The Firm",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = 978 - 0553394781,
                        Category = "Fiction, Thrillers",
                        Price = 5.26,
                        Pages = 351,
                    },

                    new Project
                    {
                        Title = "Book of Mormon",
                        Author = "Mormon",
                        Publisher = "Martin Harris",
                        ISBN = 111 - 0553393613,
                        Category = "History, Non-Fiction",
                        Price = 1.00,
                        Pages = 600,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
