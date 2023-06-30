using DDS.Modules.Customers.Application;
using DDS.Modules.Customers.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCustomerModule(builder.Configuration);

var app = builder.Build();
app.MapPost("/new", async (ICustomerRepository repository) => await CreateCustomer(repository));
app.Run();

async Task<IResult> CreateCustomer(ICustomerRepository repository)
{
    var customer = Customer.Create(Guid.NewGuid());
    repository.AppendChanges(customer);
    await repository.SaveChangesAsync();

    return Results.Created("/", customer.Id);
}