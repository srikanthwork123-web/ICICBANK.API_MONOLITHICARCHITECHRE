using ICICBANK.API_MONOLITHICARCHITECHRE.Interfaces.BANK_ACCOUNTS;
using ICICBANK.API_MONOLITHICARCHITECHRE.Repository.BANK_ACCOUNTS;
using ICICBANK.API_MONOLITHICARCHITECHRE.Services.BANK_ACCOUNTS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountsRepository, Accountsrepository>();
builder.Services.AddScoped<IAccountsService, Accountsservice>();
//Inject all the project level dependencies here....
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
