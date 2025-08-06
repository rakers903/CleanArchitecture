using Configuration.ValueObjects;
using ConsoleApp.GoodArchitecture.BusinessRules.Abstractions;
using ConsoleApp.GoodArchitecture.BusinessRules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.GoodArchitecture;

internal class Application
{
    private IUserInterface _userInterface;
    private IPersonRepository _personRepository;
    private Config _config;
    public Application(IUserInterface userInterface, IPersonRepository personRepository, Config config)
    {
        _userInterface = userInterface;
        _personRepository = personRepository;
        _config = config;
    }
    public void Start()
    {
        Console.WriteLine($"Running in Environment: {_config.Environment}");
        DisplayHomePage();
    }
    private void DisplayHomePage()
    {
        List<Person> people = _personRepository.Load();
        StringBuilder messageBuilder = new StringBuilder();
        foreach(var person in people)
        {
            messageBuilder.Append($"Person: {person.FirstName}, ");
        }
        string message = messageBuilder.ToString();
        _userInterface.DisplayMessage(message);
    }
}
