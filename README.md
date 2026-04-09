Student Management System API assignment project
I developed a Student Management System API built using ASP.NET Core Web API with .NET 8. It is designed to manage student data with secure and structured architecture.

* Technologies used :
- .NET version 8
- SQL Server for Database
- Entity framework core for entity relationship
- JWT authentication 
- Serilog for logging

* Features and functionality working:
- CRUD operations for students such as add, view, update, delete and view by id also
- JWT based authentication for secure access
- Clean layer architecture by using controllers, services and repositories
- Global exception handling for error management here I used Exceptionclass
- Logging support using Serilog
- Swagger for API testing

* Project Flow and Overview to easy understanding
1. User sends request through Swagger or any client
2. Request goes to Controller then
3. Controller calls Service layer after that
4. Service processes logic and calls Repository
5. Repository interacts with database using Entity Framework
6. Response is returned back to user
7. If any error occursthen it is handled by global middleware

* How to Run the Project :
1. Open appsettings file and update database connection string with your SQL Server details
2. Run the database migration using Update Database command in Package Manager Console
3. Open project in Visual Studio and run the application
4.Swagger will open in browser where you can test APIs
After that Swagger is open then

Authentication Steps
1. Use login API with   username : admin and password : 123
2. Copy the token from response
3. Click authorize button in Swagger it is in green in colour
4. Paste token with Bearer keyword
5.Then after that now you can access protected APIs like add,get,update,delelte

* Folder Structure :
- Controllers contain API endpoints
- Services contain business logic
- Repositories handle database operations
- Models define data structure, entity
- Middleware handles exception error (i.e) exception class i added there
- Data contains database context (i.e : DbContext
- Logs folder stores log files (i.e : history)
