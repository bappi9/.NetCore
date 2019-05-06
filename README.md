# .NetCoreSqlConnection
.Net Core Sql Connection with Entity Framework and Dapper ORM(Dot Net Core)
# Nuget Pakeges
1.microsoft.extensions.configuration
2.microsoft.extensions.configuration.json
3.system.data.SqlClient
4.System.Data.Common
5.Microsoft.EntityFrameworkCore.SqlServer
6.Microsoft.EntityFrameworkCore.Tools
7.Microsoft.EntityFrameworkCore.Design

# Data First Console Mode scaffold
scaffold-DbContext "Data Source=test;Initial Catalog=test;User ID=test;Password=test;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models" -ContextDir "DbContexts"
