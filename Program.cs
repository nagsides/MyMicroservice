/*
This code is an example of configuring a simple ASP.NET Core web application with 
Swagger documentation. Here is an explanation of the various parts of the code:

The first line of the code creates a new instance of the WebApplication builder class, 
which provides a fluent API for configuring the application.

The next few lines configure the services that are registered with the application's 
dependency injection container. 
The first line adds the controllers to the container, which are used to handle incoming 
HTTP requests. 
The next two lines configure Swagger documentation. AddEndpointsApiExplorer() adds an 
endpoint that serves the Swagger JSON document, and AddSwaggerGen() generates the Swagger 
specification based on the attributes of the application's controllers and models.

The next line builds the application based on the configuration specified in the builder.

The next block of code sets up the middleware pipeline that will handle incoming HTTP 
requests. If the application is running in development mode (which is determined by 
checking the environment variable ASPNETCORE_ENVIRONMENT), the app.UseSwagger() and app.
UseSwaggerUI() middleware are added to the pipeline to serve the Swagger documentation. 
The UseAuthorization middleware is added to enable authorization checks on incoming 
requests. 
The app.MapControllers() method maps the incoming requests to the appropriate controller 
action, based on the route defined in the controller.

Finally, the app.Run() method is called to start the application and begin listening for 
incoming HTTP requests.

Overall, this code demonstrates the basics of configuring a simple web application 
using ASP.NET Core, including adding controllers and middleware, and configuring Swagger 
documentation.

*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
