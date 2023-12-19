### 1. Install Pakages for Communitation to PostgreSQL
___
1. dotnet add package Microsoft.EntityFrameworkCore
2. dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL


### 2. Docker Compose up
___
- docker-compose up -d


### 3. Migration Table
___
1. dotnet add package Microsoft.EntityFrameworkCore.Design
2. dotnet build
3. dotnet ef migrations add CreateTodoTable
4. dotnet ef database update

### 4. API Test
___
- With Postman