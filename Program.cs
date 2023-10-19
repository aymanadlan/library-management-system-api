
using library_management_system__api.Data;
using library_management_system_api.Data;
using library_management_system_api.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace library_management_system_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
            });

            //Add AppdbContext
            builder.Services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Configure Services
            builder.Services.AddScoped<IBooksService, BooksService>();


            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            //Seed the tables with initial data
            AppDbInitializer.Seed(app);

            app.Run();
        }
    }
}