using System.Text;
using DDS.Modules.Customers.Configuration;
using DDS.Modules.Customers.Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services
    .AddCustomerModule(config)
    .AddGraphQLServer()
    .AddLocalSchema("Customers");


// builder.Services
    // .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    // .AddMicrosoftAccount(options =>
    // {
    //     options.ClientId = builder.Configuration["Authentication:Microsoft:ClientId"]!;
    //     options.ClientSecret = builder.Configuration["Authentication:Microsoft:ClientSecret"]!;
    //     options.SaveTokens = true;
    // })
    // .AddCookie();

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options =>
//     {
//         options.Authority = $"https://login.microsoftonline.com/{Configuration["AzureAd:TenantId"]}/v2.0"; // where AzureAd:TenantId is your Tenant ID
//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidateIssuer = true,
//             ValidIssuer = $"https://login.microsoftonline.com/{Configuration["AzureAd:TenantId"]}/v2.0",
//             ValidateAudience = true,
//             ValidAudience = Configuration["AzureAd:ClientId"], // where AzureAd:ClientId is your Client ID
//             ValidateLifetime = true
//         };
//     });



// builder.Services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
// {
//     options.TokenValidationParameters = new TokenValidationParameters
//     {
//         ValidateIssuer = true,
//         ValidateAudience = true,
//         ValidateLifetime = true,
//         ValidateIssuerSigningKey = true,
//
//         ValidIssuer = "thomas",
//         ValidAudience = "builder.Configuration[\"Jwt:Audience\"]",
//         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["testkey"]))
//     };
// });



// builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseAuthentication();
// app.UseAuthorization();

// app.MapGet("/", (HttpContext context) =>
// {
//     //context.GetTokenAsync("access_token");
//     return context.User.Claims.Select(c => new { c.Type, c.Value }).ToList();
// });
// app.MapGet("/login", () =>
//     Results.Challenge(
//         new AuthenticationProperties()
//         {
//             RedirectUri = "https://localhost:5000/"
//         },
//         authenticationSchemes: new List<string> { MicrosoftAccountDefaults.AuthenticationScheme }));
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