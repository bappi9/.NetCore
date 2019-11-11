# .NetCoreSqlConnection
.Net Core Sql Connection with Entity Framework and Dapper ORM(Dot Net Core)
# Nuget Package
1.microsoft.extensions.configuration
2.microsoft.extensions.configuration.json
3.system.data.SqlClient
4.System.Data.Common
5.Microsoft.EntityFrameworkCore.SqlServer
6.Microsoft.EntityFrameworkCore.Tools
7.Microsoft.EntityFrameworkCore.Design

# Data First Console Mode scaffold
scaffold-DbContext "Data Source=test;Initial Catalog=test;User ID=test;Password=test;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models" -ContextDir "DbContexts" -schema "mds" -f

# Swagger Add Package
Install-Package Swashbuckle.AspNetCore -Version 5.0.0-rc4
Install-Package Swashbuckle.AspNetCore.Annotations -Version 5.0.0-rc4

 public void ConfigureServices(IServiceCollection services)
 
 {
  services.AddSwaggerGen(c =>
    
   {
          c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "ToDo API",
            Description = "A simple example ASP.NET Core Web API",
            TermsOfService = new Uri("https://example.com/terms"),
            
            Contact = new OpenApiContact
            {
                Name = "Shayne Boyer",
                Email = string.Empty,
                Url = new Uri("https://twitter.com/spboyer"),
            },
            
            License = new OpenApiLicense
            {
                Name = "Use under LICX",
                Url = new Uri("https://example.com/license"),
            }
      });
   });
 }
 
 
 public void Configure(IApplicationBuilder app)

 {
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");In the 
    });

    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
#Help for Swagger
https://github.com/aspnet/AspNetCore.Docs/tree/master/aspnetcore/tutorials/web-api-help-pages-using-swagger/samples/3.0/TodoApi.Swashbuckle
