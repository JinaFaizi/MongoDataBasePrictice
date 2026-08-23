# MongoDbPractice

A practice ASP.NET Core Web API project for learning MongoDB, asynchronous programming, and Reflection.

## Technologies

- C#
- ASP.NET Core Web API
- MongoDB
- MongoDB.Driver
- Swagger
- Async / Await
- Reflection

## Architecture

This project uses a simple two-project architecture:

```text
MongoDbPractice
│
├── ProductCatalog.API
│   ├── Controllers
│   ├── Program.cs
│   └── appsettings.json
│
└── ProductCatalog.Core
    ├── Entities
    ├── Interfaces
    ├── Services
    └── Data