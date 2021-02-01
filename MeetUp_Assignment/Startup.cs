using MeetUp_Assignment.Extensions;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace MeetUp_Assignment
{
    public class Startup
    {
        public IWebHostEnvironment HostingEnvironment { get; private set; }
        public IConfiguration Configuration { get; private set; }
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
          .AddEnvironmentVariables();
            configuration = builder.Build();
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection Services)
        {
            Services.ConfigureCors();
            Services.ConfigureIISIntegration();
            Services.ConfigureMySqlContext(Configuration);
            Services.ConfigureRepositoryWrapper();
            Services.AddAutoMapper(typeof(Startup));
            Services.AddControllers();
            //loggerFactory.AddLog4Net();
            Services.AddMvc();
            Services.ConfigureSwagger();
            
            Services.ConfigureFactoryService();
            Services.Configure<MvcOptions>(options =>
            {
                options.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCors("CorsPolicy");
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            loggerFactory.AddLog4Net();
            app.UseRouting();
            app.UseMvc();

            app.UseAuthorization();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"   );
                //endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
