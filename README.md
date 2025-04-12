📦 GraphQLMongoDemo

A minimal ASP.NET Core application using GraphQL and MongoDB to demonstrate basic CRUD operations on an Item collection.
🚀 Features

    ⚙️ Built with ASP.NET Core

    🔍 GraphQL for flexible querying & mutations

    🧩 MongoDB for NoSQL data persistence

    ✅ CRUD operations (Create, Read, Update, Delete)

    🧪 Supports LINQ querying via MongoDB driver

    GraphQLMongoDemo/
│
├── Data/               # MongoDB context setup
│   └── MongoContext.cs
│
├── Models/             # Data models
│   └── Item.cs
│
├── GraphQL/
│   ├── Mutations/      # GraphQL mutations (add, update, delete)
│   │   └── ItemMutation.cs
│   └── Queries/        # GraphQL queries (get items)
│       └── ItemQuery.cs
│
├── Startup.cs          # GraphQL service registration
└── Program.cs          # Entry point
🛠️ Setup Instructions
1. 🧾 Prerequisites

    .NET SDK 7.0+

    MongoDB

2. 📥 Clone the repository

git clone https://github.com/yourusername/GraphQLMongoDemo.git
cd GraphQLMongoDemo

3. ⚙️ Configure MongoDB

Update the MongoContext.cs with your MongoDB connection string and database name.

private readonly IMongoDatabase _database;

public MongoContext(IConfiguration config)
{
    var client = new MongoClient(config["MongoDB:ConnectionString"]);
    _database = client.GetDatabase(config["MongoDB:DatabaseName"]);
}

Add the settings to appsettings.json:

"MongoDB": {
  "ConnectionString": "mongodb://localhost:27017",
  "DatabaseName": "GraphQLDemoDb"
}

4. 📦 Install NuGet Packages

Install dependencies (if not already added):

dotnet add package MongoDB.Driver
dotnet add package HotChocolate.AspNetCore
dotnet add package HotChocolate.Data

5. ▶️ Run the application

dotnet run

Visit the Banana Cake Pop GraphQL IDE (usually at https://localhost:{port}/graphql) to interact with the API.
