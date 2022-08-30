using WebApi.Domain.Models;
using WebApi.Domain.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System;

using WebApi.DataFaker;

namespace WebApi.DataAccess.Data
{
    public class DataSeeder
    {
        private static int _iter = 5;

        public static void Initialize(ApplicationDbContext context)
        {
            var dataFaker = new DataProvider();
            // // where to begin?

            // // seed organizations
            if (!context.Organizations.Any())
            {
                var orgs = new List<Organization>();
                for (int i = 0; i < _iter; i++)
                {
                    var org = dataFaker.NewOrganization();
                    orgs.Add(org);
                    // Console.WriteLine(org);
                }
                context.Organizations.AddRange(orgs);
                context.SaveChanges();
            }

            if (!context.Locations.Any())
            {

                var locs = new List<Location>();

                var orgs = context.Organizations.ToArray();
                foreach (var org in orgs)
                {
                    for (int i = 0; i < _iter; i++)
                    {
                        var loc = dataFaker.NewLocation(org);
                        locs.Add(loc);
                        // Console.WriteLine("Printing output:");
                        Console.WriteLine(loc);
                    }
                    context.Locations.AddRange(locs);
                    context.SaveChanges();
                }
            }

            // // Addresses are added with locations
            // if (!context.Addresses.Any())
            // {
            //     var addrs = new List<Address>();
            //     for (int i = 0; i < _iter; i++)
            //     {
            //         var addr = dataFaker.NewAddress();
            //         addrs.Add(addr);
            //         // Console.WriteLine(addr);
            //     }
            // }


        }


        public static void InitializeRecipes(ApplicationDbContext context)
        {
            // DataProvider dataFaker = new DataProvider();
            if (!context.Users.Any())
            {
                var users = new List<User>()
                {
                    new User { /*Id = 1,*/ Name = "John", Email = "john@john.com" },
                    new User { /*Id = 2,*/ Name = "Michael", Email = "michael@michael.com" }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            if (!context.Recipes.Any())
            {
                var recipes = new List<Recipe>()
                {
                    new Recipe { /* Id = 1 */ Name = "Pizza", Description = "A random description from a pizza", Difficulty = RecipeDifficulty.MEDIUM, ImagePath = "https://upload.wikimedia.org/wikipedia/commons/a/a4/Pizza.jpg", Time = 30, UserId = 1 }
                };
                context.Recipes.AddRange(recipes);
                context.SaveChanges();
            }

            if (!context.Ingredients.Any())
            {
                var ingredients = new List<Ingredient>()
                {
                    new Ingredient { /* Id = 1 */ Name = "Cheese", Amount = 1, RecipeId = 1 },
                    new Ingredient { /* Id = 2 */ Name = "Tomato", Amount = 2, RecipeId = 1 }
                };
                context.Ingredients.AddRange(ingredients);
                context.SaveChanges();
            }


            ///// DEBUG BELOW!

            // if (!context.Books.Any())
            // {
            //     var books = new List<Book>();
            //     for (var i = 0; i < 10; i++)
            //     {
            //         Book book = dataFaker.NewBook();
            //         books.Add(book);
            //         Console.WriteLine(book);
            //     }
            //     context.Books.AddRange(books);
            //     context.SaveChanges();
            // }

            // if (!context.Addresses.Any())
            // {
            //     var addresses = new List<Address>();
            //     for (var i = 0; i < 10; i++)
            //     {
            //         Address address = dataFaker.NewAddress();
            //         addresses.Add(address);
            //         Console.WriteLine(address);
            //     }
            //     context.Addresses.AddRange(addresses);
            //     context.SaveChanges();
            // }

            // if (!context.Authors.Any())
            // {
            //     var authors = new List<Author>();
            //     for (var i = 0; i < 10; i++)
            //     {
            //         Author author = dataFaker.NewAuthor();
            //         authors.Add(author);
            //         Console.WriteLine(author);
            //     }
            //     context.Authors.AddRange(authors);
            //     context.SaveChanges();
            // }

        }



    }
}
