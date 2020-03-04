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

## How to Test

First, install [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1). Then, open the terminal or command prompt at the API root path (`/StarWarsAPI/`) and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to `https://localhost:5001/swagger` to check the API documentation.
Using service `/api/Starship/Distance/{distance}`to calculate the distance
