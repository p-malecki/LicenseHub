# ORM

[How YOU can use an ORM in .NET Core and C# to type less SQL -starring Entity Framework](https://softchris.github.io/pages/dotnet-orm.html#create-the-database)

 Lazy Loading --> **Microsoft.EntityFrameworkCore.Proxie**s
 .UseLazyLoadingProxies()

<img title="" src="file:///C:/Users/Paweł/AppData/Roaming/marktext/images/2023-11-18-17-53-37-image.png" alt="" width="394">

Monitorowanie długości wykonywania zapytań

<img src="file:///C:/Users/Paweł/AppData/Roaming/marktext/images/2023-11-18-17-50-40-image.png" title="" alt="" width="193">

Blokowanie śledzenia obiektów w zapytaniach tylko do odczytu
<img title="" src="file:///C:/Users/Paweł/AppData/Roaming/marktext/images/2023-11-18-17-50-27-image.png" alt="" width="124">

Filtrowanie danych po stronie serwera

**EFCore.BulkExtensions**
await context.BulkInsertAsync(books);

**optionsBuilder**

.UseLoggerFactory(_loggerFactory)

.EnableSensitiveDataLogging()

.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)

# **NLog**

[GitHub - NLog/NLog: NLog - Advanced and Structured Logging for Various .NET Platforms](https://github.com/NLog/NLog)
https://www.modestprogrammer.pl/logowanie-danych-do-pliku-w-csharpie-za-pomoca-biblioteki-nlog



# Web Tokens (JWT) w C#

[Bezpieczna implementacja JSON Web Tokens (JWT) w C#](https://bulldogjob.pl/readme/bezpieczna-implementacja-json-web-tokens-jwt-w-c)


