# .NetCoreSqlConnection
.Net Core Sql Connection with Entity Framework and Dapper ORM(Dot Net Core)
# Nuget Package
1.Install-Package microsoft.extensions.configuration
2.Install-Package microsoft.extensions.configuration.json
3.Install-Package system.data.SqlClient
4.Install-Package System.Data.Common
5.Install-Package Microsoft.EntityFrameworkCore.SqlServer
6.Install-Package Microsoft.EntityFrameworkCore.Tools
7.Install-Package Microsoft.EntityFrameworkCore.Design

#...
Install-Package microsoft.extensions.configuration
Install-Package microsoft.extensions.configuration.json
Install-Package system.data.SqlClient
Install-Package System.Data.Common
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package System.Linq.Dynamic.Core -Version 1.0.19
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 3.1.0
Install-Package Microsoft.IdentityModel.Tokens -Version 5.6.0
Install-Package System.IdentityModel.Tokens.Jwt -Version 5.6.0
Install-Package Swashbuckle.AspNetCore -Version 5.0.0-rc4
Install-Package Swashbuckle.AspNetCore.Annotations -Version 5.0.0-rc4


# Data First Console Mode scaffold
scaffold-DbContext "Data Source=test;Initial Catalog=test;User ID=test;Password=test;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models" -ContextDir "DbContexts" -schema "mds" -f

# ElasticSearch with Serilog install

Install-Package Serilog.Exceptions

Install-Package Serilog

Install-Package Serilog.Enrichers.Environment

Install-Package Serilog.Extensions.Logging

Install-Package Serilog.Sinks.Elasticsearch

Install-Package Elastic.Apm.NetCoreAll

  public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
           

            var elasticUri = "http://172.17.17.25:8064/";//Configuration["ElasticConfiguration:Uri"];

            Log.Logger = new LoggerConfiguration()
               .Enrich.FromLogContext()
               .Enrich.WithExceptionDetails()
               .Enrich.WithMachineName()
               .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticUri))
               {
                   AutoRegisterTemplate = true,
               })
            .CreateLogger();
        }
            
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddSerilog();
             
            loggerFactory.AddSerilog();
            // app.UseHttpsRedirection();
            app.UseStaticFiles();
            // app.UseCookiePolicy();

            
        }
        
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
# APiGateway with Ocelot run Swaager

Install-Package MMLib.SwaggerForOcelot -Version 2.0.0-alpha.2

#Help for Swagger
https://github.com/aspnet/AspNetCore.Docs/tree/master/aspnetcore/tutorials/web-api-help-pages-using-swagger/samples/3.0/TodoApi.Swashbuckle


#Intelligence  Business Operation System
iBOS
 └── msto     
 |      ├── Controler
 |      |     └── EmployeeController.cs
 |      ├── Helper
 |      |     └── JsonConverter.cs
 |      ├── Repository
 |      |      └── HR
 |      |      |    └── Employee.cs
 |      ├── IRepository
 |      |      └── HR
 |      |      |    └── IEmployee.cs
 |      ├── DataTransferObject
 |      |      └── EmployeeDetalisDTO.cs
 |      ├── Model
 |      |      └── HR
 |      |      |   └── tblEmployee.cs     
 |      ├── Db_COntext
 |      |      └── HR
 |      |      |   └── Db_context_Hr.cs
 |      ├── Strtup.cs
 |      ├─ Program.cs
 └── fino
 |      ├── Controler
 |      |     └── AccountsController.cs
 |      ├── Helper
 |      |     └── JsonConverter.cs
 |      ├── Repository
 |      |      └── fino
 |      |      |    └── Accounts.cs
 |      ├── IRepository
 |      |      └── fino
 |      |      |    └── IAccounts.cs
 |      ├── DataTransferObject
 |      |      └── EmployeeDetalisDTO.cs
 |      ├── Model
 |      |      └── fino
 |      |      |   └── tblAccounts.cs     
 |      ├── Db_COntext
 |      |      └── fino
 |      |      |   └── Db_context_Fino.cs
 |      ├── Strtup.cs
 |      ├─ Program.cs
 └── hrso
 └── sado
 └── scmo
 └── logo
 └── meso
 └── crmo
