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

# ...
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
# Testing Pakage
install-Package MartinCostello.Logging.XUnit -Version 0.1.0
install-Package Microsoft.AspNetCore.Hosting.Abstractions -Version 2.2.0
install-Package Microsoft.AspNetCore.Mvc.Testing -Version 3.1.3
install-Package Microsoft.Extensions.Hosting.Abstractions -Version 3.1.3
install-Package Microsoft.Extensions.Logging -Version 3.1.3
install-Package Microsoft.Extensions.Logging.Abstractions -Version 3.1.3
install-Package Microsoft.NET.Test.Sdk -Version 16.2.0
install-Package Microsoft.VisualStudio.Threading -Version 16.6.13
Install-Package xunit -Version 2.4.1
Install-Package xunit.runner.visualstudio -Version 2.4.1

# APiGateway with Ocelot run Swaager

Install-Package MMLib.SwaggerForOcelot -Version 2.0.0-alpha.2

# Help for Swagger
https://github.com/aspnet/AspNetCore.Docs/tree/master/aspnetcore/tutorials/web-api-help-pages-using-swagger/samples/3.0/TodoApi.Swashbuckle


# Intelligence  Business Operation System
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
 
#Odata Swager Configuration
Note:https://github.com/OData/WebApi/issues/2024
services.AddMvcCore(options =>
{
   foreach (var outputFormatter in options.OutputFormatters.OfType<OutputFormatter>().Where(x => x.SupportedMediaTypes.Count == 0))
   {
          outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
    }

   foreach (var inputFormatter in options.InputFormatters.OfType<InputFormatter>().Where(x => x.SupportedMediaTypes.Count == 0))
   {
         inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
   }
});
  
# OData Stratup configureation with lowarcase
  
   public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddSerilog();
            app.UseAllElasticApm(Configuration);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
                     .AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader());

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.ConfigureCustomExceptionMiddleware();

            //Enable Swagger middleware and endpoint

            app.UseSwagger(c =>
            {
                c.RouteTemplate = "sme/swagger/{documentName}/swagger.json";
            });

            //specifying the Swagger JSON endpoint.

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/sme/swagger/v1/swagger.json", "Procurement Management");
                c.RoutePrefix = "sme/swagger";
            });


            app.UseHttpsRedirection();

            //app.UseMvc(routeBuilder =>
            //{
            //    routeBuilder.EnableDependencyInjection();
            //    routeBuilder.Expand().Select().Count().Filter().OrderBy();
            //    //routeBuilder.Select().Filter().Expand();
            //    routeBuilder.MapODataServiceRoute("sme", "sme", GetEdmModel());
            //});
            app.UseEndpoints(endpoint=>
            {
                endpoint.EnableDependencyInjection();
                endpoint.Expand().Select().Count().Filter().OrderBy();
                endpoint.MapODataRoute(routeName: "sme", routePrefix: "sme",model: GetEdmModel());
              
            });

        }
        private IEdmModel GetEdmModel()
        {
            var edmBuilder = new ODataConventionModelBuilder();
            edmBuilder.EntitySet<Customer>("Customer");
           
           //Addition for mongodb
            edmBuilder.EntityType<Customer>().HasKey(ai => ai.Id); // the call to HasKey is mandatory
            edmBuilder.EnableLowerCamelCase();//https://stackoverflow.com/questions/55188232/why-is-my-http-post-no-longer-passing-the-body-content-after-adding-microsoft-as
            return edmBuilder.GetEdmModel();
        }
  
 
# MongoDB
  Install-Package MongoDB.Bson -Version 2.11.2
  Install-Package MongoDB.Driver -Version 2.11.2
# Latest
 Install-Package System.Linq.Dynamic.Core -Version 1.1.5
Install-Package System.IdentityModel.Tokens.Jwt -Version 5.5.0
Install-Package System.Data.SqlClient -Version 4.8.1
Install-Package System.Data.Common -Version 4.3.0
Install-Package System.Configuration.ConfigurationManager -Version 4.7.0
Install-Package Swashbuckle.AspNetCore.Annotations -Version 5.0.0-rc4
Install-Package Swashbuckle.AspNetCore -Version 5.0.0-rc4
Install-Package Serilog.Sinks.ElasticSearch -Version 8.0.1
Install-Package Serilog.Extensions.Logging -Version 3.0.1
Install-Package Serilog.Exceptions -Version 5.4.0
Install-Package Serilog.Enrichers.Environment -Version 2.1.3
Install-Package Serilog -Version 2.9.0
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 3.1.3
Install-Package Microsoft.VisualStudio.Azure.Containers.Tools.Targets -Version 1.9.10
Install-Package Microsoft.IdentityModel.Tokens -Version 5.6.0
Install-Package Microsoft.Extensions.Configuration.Json -Version 3.1.3
Install-Package Microsoft.Extensions.Configuration -Version 3.1.3
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.3
Install-Package Microsoft.EntityFrameworkCore.Design -Version 3.1.3
Install-Package Microsoft.AspNetCore.Mvc.Core -Version 2.2.5
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 3.1.0
Install-Package Microsoft.AspNet.WebPages.WebData -Version 3.2.7
Install-Package MediatR.Extensions.Microsoft.DependencyInjection -Version 8.0.0
Install-Package MailKit -Version 2.7.0
Install-Package Elastic.Apm.NetCoreAll -Version 1.4.0
