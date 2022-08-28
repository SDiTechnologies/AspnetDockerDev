using WebApi.Domain.Models;
using WebApi.Domain.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System;

namespace WebApi.DataAccess.Data
{
    public class DataSeeder
    {
        public static void Initialize(ApplicationDbContext context)
        {
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

            if (!context.Books.Any())
            {
                var books = new List<Book>()
                {
                    new Book { /* Id = 1 */ Title = "You Left Me In San Fran Cheesy", ReleaseDate = DateTime.UtcNow },
                    new Book { /* Id = 2 */ Title = "Pasta La Vista, Baby",  ReleaseDate = DateTime.UtcNow}
                };
                context.Books.AddRange(books);
                context.SaveChanges();
            }

        }
    }
}
