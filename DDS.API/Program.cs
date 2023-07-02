using DDS.Modules.Customers.Configuration;
using DDS.Modules.Customers.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCustomerModule(builder.Configuration)
    .AddGraphQLServer()
    .AddLocalSchema("Customers")
    // .AddRemoteSchema<CustomerSchemaService>("customers")
    // .AddRemoteSchema("Customers")
    ;

var app = builder.Build();


app.MapPost("/new", async (ICustomerRepository repository) => await CreateCustomer(repository));
app.MapGet("/customer/{id:guid}",
    async (ICustomerRepository repository, Guid id) => await repository.LoadAsync<Customer>(id));


app.MapGraphQL();
app.Run();

async Task<IResult> CreateCustomer(ICustomerRepository repository)
{
    var customer = Customer.Create(Guid.NewGuid());
    repository.AppendChanges(customer);
    await repository.SaveChangesAsync();

    return Results.Created($"/customer/{customer.Id}", customer);
}