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
/*MicroService Urls:
 * ====
=============After deploying this project it shows like this way===
===============dev region url========
https://dev-ICICBANKOverviewAPi.com/APi/
https://dev-ICICBANKBankAccountsAPi.com/APi/
https://dev-ICICBANKPaymentsAndTransferAPi.com/APi/
https://dev-ICICBANKCardsAndLoansAPi.com/APi/
https://dev-ICICBANKInvestmentsAndInsuranceAPi.com/APi/
https://dev-ICICBANKCustomerServiceAPi.com/APi/


=================uat region url===
https://Uat-ICICBANKOverviewAPi.com/APi/
https://Uat-ICICBANKBankAccountsAPi.com/APi/
https://Uat-ICICBANKPaymentsAndTransferAPi.com/APi/
https://Uat-ICICBANKCardsAndLoansAPi.com/APi/
https://Uat-ICICBANKInvestmentsAndInsuranceAPi.com/APi/
https://Uat-ICICBANKCustomerServiceAPi.com/APi/


=================Qa region url===
https://Qa-ICICBANKOverviewAPi.com/APi/
https://Qa-ICICBANKBankAccountsAPi.com/APi/
https://Qa-ICICBANKPaymentsAndTransferAPi.com/APi/
https://Qa-ICICBANKCardsAndLoansAPi.com/APi/
https://Qa-ICICBANKInvestmentsAndInsuranceAPi.com/APi/
https://Qa-ICICBANKCustomerServiceAPi.com/APi/


=================Production region url===
https://ICICBANKOverviewAPi.com/APi/
https://ICICBANKBankAccountsAPi.com/APi/
https://ICICBANKPaymentsAndTransferAPi.com/APi/
https://ICICBANKCardsAndLoansAPi.com/APi/
https://ICICBANKInvestmentsAndInsuranceAPi.com/APi/
https://ICICBANKCustomerServiceAPi.com/APi/


 */
/*
 /*
 *1)can you please explain how to call  3rd part api url in dotnetcore?
 A)to call the 3rd part api url in dotnetcore,we need to use HttpClient class which is used to send http requests and receive http responses from a  3rd part apis.
we need to fallow this process step by step
========================================================================================================================
string ApiUrl = "https://fakerestapi.azurewebsites.net/api/v1/Users";//here we need to specify the 3rd part api url which we want to call.
string url = string.Format(ApiUrl, id);//if the api url contains any path parameters like id,then we need to use string.Format method to replace the path parameters with the actual values which we want to pass in the api url.
HttpClient client = new HttpClient();//HttpClient class is predefined class,which  is used to communicate with 3rdpart apis.need to create the object of HttpClient class to call the 3rd part api url.
var request = new HttpRequestMessage(HttpMethod.Delete, url);//HttpRequestMessage class is predefined class which is used to create http request message to send to the 3rd part api.
request.Headers.Add("accept", "application/json");//what type of response you are expecting api response.you should specify here.
//HttpResponseMessage class is predefined class which is used to receive http response message from the 3rd part api.SendAsync() method is used to send the http request message to the 3rd part api and receive the http response message from the 3rd part api.
HttpResponseMessage response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();//it will throw an exception if the api response status code is not success status code.
var responseData = await response.Content.ReadAsStringAsync();//it will read the response data from the api response and return it as a string format.
return responseData;//finally we are returning the response data which we are getting from the api response to the service layer.
==========================================================================================================================
*/
*/