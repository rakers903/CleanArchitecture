using Configuration.ValueObjects;
using ConsoleApp.GoodArchitecture;
using ConsoleApp.GoodArchitecture.Data;
using ConsoleApp.GoodArchitecture.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ApplicationFactory
    {
        public static Application Build(Config applicationConfig)
        {
            string? environment = applicationConfig.Environment;
            if(environment != null)
            {
                return environment switch
                {
                    "development" => new Application(
                        new DevelopmentUserInterface(), 
                        new DevelopmentPersonRepository(), 
                        applicationConfig
                    ),
                    "production" => new Application(
                        new ProductionUserInterface(), 
                        new ProductionPersonRepository(),
                        applicationConfig
                    ),
                    _ => throw new Exception("Error creating Application")
                };
            }
            throw new Exception("Error creating Application");
        }
    }
}
