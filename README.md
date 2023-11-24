# CityInfo API

CityInfo API is an ASP.NET Core application that provides information about cities and their points of interest.

## Features

- **Logging**: Utilizes Serilog for logging, writing logs to both the console and a file.

- **Dependency Injection**: Leverages ASP.NET Core built-in DI container for service registration and management.

- **Entity Framework Core**: Uses SQLite database via Entity Framework Core in the CityInfoContext.

- **Swagger/OpenAPI Documentation**: Includes Swagger UI for generating and visualizing API documentation.

- **Mail Service**: Configurable mail service (LocalMailService or CloudMailService) based on the application mode (DEBUG or other).

- **Repository Pattern**: Implements a repository pattern in the CityInfoRepository to interact with the database.

- **AutoMapper**: Utilizes AutoMapper for mapping between entity models and Data Transfer Objects (DTOs).

- **Authentication and Authorization**: Configures JWT Bearer authentication and authorization policies.
