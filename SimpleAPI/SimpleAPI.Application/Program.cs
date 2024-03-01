
using Microsoft.EntityFrameworkCore;
using SimpleAPI.Domains;
using SimpleAPI.Domains.Interfaces;
using SimpleAPI.Infrastructure;
using SimpleAPI.Infrastructure.Context;
using SimpleAPI.Infrastructure.Interfaces;

namespace SimpleAPI.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("Books"));

            // Add services to the container.
            builder.Services.AddScoped<IBooks, Books>();
            builder.Services.AddScoped<IBookData, BookData>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
