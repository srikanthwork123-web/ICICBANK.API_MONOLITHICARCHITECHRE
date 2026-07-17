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
/*
1.What is Monolithic architecture?
A)
=>Monolithic architecture menas if you develop any project,they mainteined only one api project for apis development and only one database used.single api project and single database used for entire project development.
=>If any application server is down ,entire production application  will not work.this is one main drawback in monolithic architecture.

2.what is microservices architecture?can you explain in detail?
A)
=>Microservices architecture means if you develop any project,they mainteined multiple api projects for apis development and multiple databases used.
=>single api project and single database used for each module development.
=>we need to deploy each microservice separetly in azure cloud or any other cloud platform.
Advantages of Microservices Architecture in .NET Core
✅ Scalability – Scale services independently based on demand.
✅ Flexibility – Develop using different technologies and databases per service.
✅ Resilience – Failure in one service doesn’t crash the entire application.
✅ Faster Deployment – Deploy and update services individually.
✅ Better Maintainability – Easier to manage and update small services.
✅ Cloud-Friendly – Works well with containers like Docker and Kubernetes.
Disadvantages
❌ Complexity – Managing multiple services is harder than a monolith.
❌ Data Management – Handling distributed databases and transactions is tricky.
❌ Latency – Network calls between services can slow performance.
❌ Monitoring Challenges – Requires robust logging and monitoring tools.
❌ Deployment Overhead – More infrastructure setup is needed.

 */

/*
 To implement microservices Architecture for each Api microservice need to create separate databases

=================================================================

Create database ICICBANKOverview

Create database ICICBANKBankAccounts

Create database ICICBANKPaymentsAndTransfer

Create database ICICBANKCardsAndLoans

Create database ICICBANKInvestmentsAndInsurance

Create database ICICBANKCustomerService

=============================== 
 */