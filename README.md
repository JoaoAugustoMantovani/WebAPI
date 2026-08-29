# User Management Web API

## Overview
This is a simple ASP.NET Core Web API project for managing users. It follows a clean architecture using the **Repository Pattern** and **Service Layer**, and it uses **Entity Framework Core** for database interactions.

## Features
*   **User Management**: Endpoints for handling user data.
*   **Data Transfer Objects (DTOs)**: Separates domain models (`User`) from API payloads (`UserDTO`, `UserResponse`).
*   **Security**: Includes a `PasswordHasher` helper for secure password storage.
*   **Database Migrations**: Entity Framework Core migrations are pre-configured (`AppDbContext`).
*   **Layered Architecture**: Separation of concerns using Controllers, Services, and Repositories.

## Project Structure
*   `Controllers/` - Contains the API endpoints (e.g., `UserController.cs`).
*   `Data/` - Contains the Entity Framework Core database context (`AppDbContext.cs`).
*   `Models/` - Contains data entities and DTOs (`User.cs`, `UserDTO.cs`, `UserResponse.cs`).
*   `Repository/` - Data access layer (`UserRepository.cs`, `IUserRepository.cs`).
*   `Service/` - Business logic layer (`UserService.cs`, `IUserService.cs`).
*   `Helpers/` - Utility classes (`PasswordHasher.cs`).
*   `Migrations/` - EF Core database migrations.

## Technologies Used
*   C# / .NET
*   ASP.NET Core Web API
*   Entity Framework Core

## Getting Started

### Prerequisites
*   [.NET SDK](https://dotnet.microsoft.com/download)
*   A suitable database configured in `appsettings.json`.

### Setup Instructions
1.  **Clone the repository** to your local machine.
2.  **Configure Database**: Open `appsettings.json` and update the database connection string.
3.  **Create a Migration**: Open a terminal in the project directory and run the following command to generate a new migration:
    ```bash
    dotnet ef migrations add "name" -o Migrations
    ```
4.  **Apply Migrations**: Run the following command to create or update the database:
    ```bash
    dotnet ef database update
    ```
5.  **Run the Application**:
    ```bash
    dotnet run
    ```