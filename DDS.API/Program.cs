using DDS.Modules.Customers.Configuration;
using DDS.Modules.Customers.Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddCustomerModule(config)
    .AddGraphQLServer()
    .AddLocalSchema("Customers");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapGet("/secure", [Authorize] () => "Secure endpoint!");
app.MapGet("/", (HttpContext context) =>
{
    return context.User.Claims.Select(c => new { c.Type, c.Value }).ToList();
})
    .RequireAuthorization();

app.MapPost("/createCustomer", async (ICustomerRepository repository) => await CreateCustomer(repository))
    .WithName("CreateCustomer")
    .WithOpenApi()
    .RequireAuthorization(); ;
app.MapGet("/customer/{id:guid}",
    async (ICustomerRepository repository, Guid id) => await repository.LoadAsync<Customer>(id))
    .WithName("GetCustomer")
    .WithOpenApi()
    .RequireAuthorization();

app.MapGraphQL();
app.Run();

async Task<IResult> CreateCustomer(ICustomerRepository repository)
{
    var customer = Customer.Create(Guid.NewGuid());
    repository.AppendChanges(customer);
    await repository.SaveChangesAsync();

    return Results.Created($"/customer/{customer.Id}", customer);
}