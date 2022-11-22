using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace WebApi
{
    public class Startup
    {
        // The Startup class configures the services available to the .NET Dependency Injection (DI) container 
        // in the ConfigureServices() method
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "dotnet 6 api", Version = "v1" });
            });
        }

        // and configures the .NET request pipeline for the application in the Configure() method. Both methods are called by the .NET runtime when the app starts, 
        // first ConfigureServices() followed by Configure()
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(x => x.MapControllers());
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }

}