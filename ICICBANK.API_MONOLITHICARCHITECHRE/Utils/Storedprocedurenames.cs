namespace DapperWith4DatabaseCommunication.Utils
{
    //whenever the no of objects creations are increased automatically perfomence of application decresed.
    //maximum if you write any code try to avoid the object creation .
    //if you use static clas ,no need to create object for static class.
    //because whenever compiler see the static keyword it loads all static related variables and mehods.
    //we can call the static variables using(static classname.variablename) and methods using(staticclassname.methodname())
    //Here to call the static related things no need to create object,due to that perfomance also increased.
    public static class Storedprocedurenames
    {//#region is used to grouping the code at one place  for better organization and readability.(singleline statement for interview purpose)
     //============================================================================================
     // #region is used to group related code together and make it easier to navigate and understand the structure of the code.
     // It allows you to collapse and expand sections of code in an IDE, making it easier to focus on specific parts of the codebase.
     // In this case, we are using #region to group the stored procedure names for each entity (Department, Order, Employee, Restaurant) together for better organization and readability.

        #region BankAccounts stored procedures
        public static string AddBankAccount = "Usp_AddBankAccount";
        public static string UpdateBankAccount = "Usp_UpdateBankAccount";
        public static string DeleteBankAccount = "Usp_DeleteBankAccount";
        public static string GetBankAccount = "Usp_GetBankAccount";
        public static string GetBankAccountById = "Usp_GetBankAccountById";
        #endregion

        #region CardsAndLoans stored procedures
        public static string AddCardsAndLoans = "Usp_AddCardsAndLoans";
        public static string UpdateCardsAndLoans = "Usp_UpdateCardsAndLoans";
        public static string DeleteCardsAndLoans = "Usp_DeleteCardsAndLoans";
        public static string GetCardsAndLoans = "Usp_GetCardsAndLoans";
        public static string GetCardsAndLoansById = "Usp_GetCardsAndLoansById";
        #endregion

        #region CustomerService storedprocedures
        public static string AddCustomer = "Usp_AddCustomer";
        public static string UpdateCustomer = "Usp_UpdateCustomer";
        public static string DeleteCustomer = "Usp_DeleteCustomer";
        public static string GetCustomer = "Usp_GetCustomer";
        public static string GetCustomerById = "Usp_GetCustomerById";
        #endregion

        #region InvestmentAndInsurance storedprocedures
        public static string AddInsurance = "Usp_AddInsurance";
        public static string UpdateInsurance = "Usp_UpdateInsurance";
        public static string DeleteInsurance = "Usp_DeleteInsurance";
        public static string GetInsurance = "Usp_GetInsurance";
        public static string GetInsuranceById = "Usp_GetInsuranceById";
        #endregion

        #region Logging storedprocedures
        public static string AddLoggingMessages = "Usp_ProjectLevelLog";
        #endregion

        #region ErrorLog storedprocedures
        public static string AddProjectLevelErrorlog = "Usp_AddProjectLevelErrorlog";
        #endregion

        #region TokenBasedAuthentication storedprocedures
        public static readonly string GetUserRolesInformation = "Usp_GetUserRolesInformation";

        public static readonly string SignIn = "Usp_LoginCheck";

        public static readonly string Usp_UserResgistration = "Usp_UserResgistration";

        public static readonly string Usp_RolesResgistration = "Usp_RolesResgistration";

        public static readonly string Usp_UserRolesMapping = "Usp_UserRolesMapping";

        #endregion
    }
}
