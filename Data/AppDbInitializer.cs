using library_management_system__api.Data;
using library_management_system__api.Models;

namespace library_management_system_api.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Book
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "Book 1",
                            Price = 100,
                            Description = "This is the description of the 1st book"
                        },
                        new Book()
                        {
                            Name = "Book 2",
                            Price = 200,
                            Description = "This is the description of the 2nd book"
                        },
                        new Book()
                        {
                            Name = "Book 3",
                            Price = 300,
                            Description = "This is the description of the 3rrf book"
                        },
                        new Book()
                        {
                            Name = "Book 4",
                            Price = 400,
                            Description = "This is the description of the 4th book"
                        },
                        new Book()
                        {
                            Name = "Book 5",
                            Price =500,
                            Description = "This is the description of the 5th book"
                        },
                        new Book()
                        {
                            Name = "Book 6",
                            Price =600,
                            Description = "This is the description of the 6th book"
                        },
                        new Book()
                        {
                            Name = "Book 7",
                            Price =700,
                            Description = "This is the description of the 7th book"
                        },
                        new Book()
                        {
                            Name = "Book 8",
                            Price =800,
                            Description = "This is the description of the 8th book"
                        },
                        new Book()
                        {
                            Name = "Book 9",
                            Price =900,
                            Description = "This is the description of the 9th book"
                        },
                        new Book()
                        {
                            Name = "Book 10",
                            Price =1000,
                            Description = "This is the description of the 10th book"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
