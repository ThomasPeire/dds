using DDS.Modules.Customers.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCustomerModule(builder.Configuration);

var app = builder.Build();

app.Run();