using ConsoleApp;
using ConsoleApp.GoodArchitecture.BusinessRules;
using ConsoleApp.GoodArchitecture.BusinessRules.Abstractions;
using ConsoleApp.GoodArchitecture.Data;
using ConsoleApp.GoodArchitecture.Presentation;
using Configuration.ValueObjects;
using Configuration.Services;
using Configuration.Abstractions;
using Configuration.Configs;
using ConsoleApp.GoodArchitecture;

//// UI -> BusinessRules -> Data

//ConsoleApp.BadArchitecture.Data data = new ConsoleApp.BadArchitecture.Data();
//ConsoleApp.BadArchitecture.BusinessRules businessRules = new(data);
//ConsoleApp.BadArchitecture.UI ui = new(businessRules);
//ui.DisplayHomeScreen();

//// --------------------------------------------------------------------------------
//// IUserInterface <- BusinessRules -> IRepository

//// DEVELOPMENT
//IUserInterface userInterface = new DevelopmentUserInterface();
//IPersonRepository personRepository = new DevelopmentPersonRepository();

//// PRODUCTION
//IUserInterface userInterface = new ProductionUserInterface();
//IPersonRepository personRepository = new ProductionPersonRepository();
//App app = new App(userInterface, personRepository);
//app.Start();
// --------------------------------------------------------------------------------
// With custom Configuration

// Load Config
string environment = "development";
string fileType = "json";
if (args.Length > 0)
{
    environment = args[0];
}
if (args.Length > 1)
{
    fileType = args[1];
}
// Could maybe swap schemas, but I already went beyond what I was planning.
Config applicationConfig = ConfigLoader.Load(environment, fileType);
// Build App
Application application = ApplicationFactory.Build(applicationConfig);
// Start App
application.Start();
