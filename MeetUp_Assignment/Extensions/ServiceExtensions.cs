using MeetUp.Services;
using Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Microsoft.OpenApi.Models;
using System.IO;
using MeetUp_Assignment.Factories;
using Microsoft.Extensions.Logging;

namespace MeetUp_Assignment.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection Services)
        {
            Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection Services)
        {
            Services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigureFactoryService(this IServiceCollection Services)
        {
            Services.AddSingleton<IUserModelFactory, UserModelFactory>();
        }
       
        public static void ConfigureMySqlContext(this IServiceCollection Services, IConfiguration config) 
        { 
            var connectionString = config["mysqlconnection:connectionString"]; 
            Services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString)); 
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection Services) 
        { 
            Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>(); 
        }


        // Register the Swagger generator, defining 1 or more Swagger documents
        public static void ConfigureSwagger(this IServiceCollection Services)
        {
            Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Assigmnet API",
                    Description = "Assignment API with GET, POST, DELETE methods",
                    Contact = new OpenApiContact
                    {
                        Name = "Dhamanand Sarate",
                        Email = "Anandsarate92@gmail.com",
                    },
                });
                c.IncludeXmlComments($@"{System.AppDomain.CurrentDomain.BaseDirectory}\MeetUp_Assignment.xml");
            });
        }
    }
}
