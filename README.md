# Student Management API

## Project Description

Student Management API is a RESTful Web API developed using ASP.NET Core Web API and Entity Framework Core. It allows users to manage student records by performing Create, Read, Update, and Delete (CRUD) operations.

## Features

- Add a new student
- View all students
- View a student by ID
- Update student details
- Delete a student
- SQL Server database integration
- Entity Framework Core
- Swagger API documentation
- Global Exception Middleware
- Serilog Logging
- Repository Pattern
- Service Layer

## Technologies Used

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- Serilog
- Git
- GitHub

## Project Structure


StudentAPI
│
├── Controllers
├── Data
├── Middleware
├── Migrations
├── Models
├── Repositories
├── Services
├── Program.cs
├── appsettings.json
└── StudentAPI.csproj


## How to Run the Project

1. Clone the repository.
2. Open the project in Visual Studio.
3. Update the SQL Server connection string in appsettings.json.
4. Run the migration:
   
   Update-Database
   
5. Press *F5* to run the application.
6. Open Swagger and test the APIs.

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/Student | Get all students |
| GET | /api/Student/{id} | Get student by ID |
| POST | /api/Student | Add a new student |
| PUT | /api/Student/{id} | Update a student |
| DELETE | /api/Student/{id} | Delete a student |

## Author

*Name:* Pasonawa
GitHub Repository:
https://github.com/pasonawa/StudentAPI
