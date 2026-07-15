using ICICBANK.API_MONOLITHICARCHITECHRE.Interfaces.BANK_ACCOUNTS;
using ICICBANK.API_MONOLITHICARCHITECHRE.Repository.BANK_ACCOUNTS;
using ICICBANK.API_MONOLITHICARCHITECHRE.Services.BANK_ACCOUNTS;
using ICICBANK_API_MONOLITHICARCHITECTURE.Interfaces.OVERVIEW;
using ICICBANK_API_MONOLITHICARCHITECTURE.Repositories.OVERVIEW;
using ICICBANK_API_MONOLITHICARCHITECTURE.Services.OVERVIEW;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountsRepository, Accountsrepository>();
builder.Services.AddScoped<IAccountsService, Accountsservice>();
builder.Services.AddScoped<IAccountSummaryRepository, AccountSummaryRepository>();
builder.Services.AddScoped<IAccountSummaryService, AccountSummaryService>();
builder.Services.AddScoped<IFinancialJourneyRepository, FinancialJourneyRepository>();
builder.Services.AddScoped<IFinancialJourneyService, FinancialJourneyService>();
builder.Services.AddScoped<IMyViewRepository, MyViewRepository>();
builder.Services.AddScoped<IMyViewService, MyViewService>();
builder.Services.AddScoped<IPersonalDetailsRepository, PersonalDetailsRepository>();
builder.Services.AddScoped<IPersonalDetailsService, PersonalDetailsService>();
//***************need to add all the project level dependencies here for dependency injection***************//
//Inject all the project level dependencies here....
//each module interface,interface implemented classes we need o register here in the program.cs file for dependency injection.
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
