# kneat-Software_StarWarsAPI

Kneat Software, Limerick (test)

## Background:

As part of this code challenge you will be using an API available here: https://swapi.co/  
We want to know for all SW star ships, to cover a given distance, how many stops for resupply are required.
The application will take as input a distance in mega lights (MGLT).
The output should be a collection of all the star ships and the total amount of stops required to make the distance between the planets.
All other application details are at your own discretion.
Sample output for 1000000 input:
Y-wing: 74
Millennium Falcon: 9
Rebel Transport: 11
NOTE: The console application can be created in any language you wish to use (not limited to .NET languages).
Requirements

1. The completed code should be submitted along with
2. Accompanying documentation
3. Tests and instructions on the usage of the application.
   If there are any queries on the challenge I can be contacted for clarification if necessary.
   All aspects of the challenge will be considered during the review, coding style, code organization, correct calculations, working application etc.
   This is a very important part of the interview process and they like our candidates to put their best code forward.

## Frameworks and Libraries

- [ASP.NET Core 3.1](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-3.1);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [AutoMapper](https://automapper.org/) (for mapping resources and models);
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation).
- [Entity Framework In-Memory Provider](https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory) (for testing purposes);
- [Microsoft.AspNetCore.Authentication.Jwt](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.authentication.jwtbearer?view=aspnetcore-3.0)(Bearer and JWT Authentication and Authorization)

## How to Test

First, install [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1). Then, open the terminal or command prompt at the API root path (`/StarWarsAPI/`) and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to `https://localhost:5001/swagger` to check the API documentation.
Using service `/api/Starship/Distance/{distance}`to calculate the distance

---

### Solution implemented :thumbsup:

**Software modeling approach was developed the challenge "DDD Architecture", Domain Driven Design (DDD).** Reference [Eric Ferreira](https://medium.com/@ericandrade_24404/parte-01-criando-arquitetura-em-camadas-com-ddd-injeção-de-dep-ef-60b851c88461).

> DDD is a software modeling approach that follows a set of practices to facilitate the implementation of complex business rules / processes that we treat as a domain. - Eduardo Pires

- 02 - Services: receives “Application” reference.
- 03 - Application: receives "Domain" reference.
- 04 - Domain: Although it is the layer that most supports the other layers, it is the only one that receives no reference from anyone, so it depends on nothing! However, as the image shows, it communicates “indirectly” with the Data (Infrastructure) layer, and this is only possible thanks to interfaces.
- 05 - Infrastructure: Last but not least, we have this layer that (as previously mentioned) has “sublayers” Data and CrossCutting, where they receive domain reference.
  Data: is intended to persist data or any other external communication.
  CrossCurring (Ioc): This is where all the interfaces and classes in the project are registered, so that it is responsible for instantiating the dependency tree of the whole architecture.

_A note on architecture:
As we can see, all layers are sequentially numbered, and this is very important, as this is exactly how the architecture flow works, from the graphical interface to the persistence of information in the database._

**Swagger** Reference [Rebai Hamida](https://medium.com/@didourebai/add-swagger-to-asp-net-core-3-0-web-api-874cb265854c).

> Swagger is a simple yet powerful representation of your RESTful API. With the largest ecosystem of API tooling on the planet, thousands of developers are supporting Swagger in almost every modern programming language and deployment environment. With a Swagger-enabled API, you get interactive documentation, client SDK generation and discoverability. -Rebai Hamida

**Authentication and Authorization with Bearer and JWT** Reference [Balta](https://balta.io/blog/aspnetcore-3-autenticacao-autorizacao-bearer-jwt).

> JWT is an industry standard (RFC-7519) that defines how to transmit and store JSON objects compactly and securely between different applications. The data contained therein can be validated at any time because the token is digitally signed. -Wellington Nascimento

_For testing authentications, the valid values for user are {Username = "batman", Password = "batman"} or {Username = "robin", Password = "robin"}_

**Other features add to the project are:**

- dependency injection
- EntityFramework
- MySql database (_unfortunately could not create a cache, but my skills are recorded_)
- Validation with data annotations
- Microsoft AspNetCore Authentication Jwt
- Auto Mapper

---

###### Note: Run StarWarsAPI as the main project.
