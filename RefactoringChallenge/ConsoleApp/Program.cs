using System;
using System.Configuration;
using DbCommon;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DapperDemoDB"].ConnectionString;

            var repository = new Repository(connectionString);
            var running = true;
            do
            {
                Console.Write("What action do you want to take (Display, Add, or Quit): ");
                var actionToTake = Console.ReadLine();

                switch (actionToTake?.ToLower())
                {
                    case "display":
                        var records = repository.ReadUsers();
                        records.ForEach(x => Console.WriteLine($"{ x.FirstName } { x.LastName }"));
                        Console.WriteLine();
                        break;

                    case "add":
                        Console.Write("What is the first name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("What is the last name: ");
                        string lastName = Console.ReadLine();

                        repository.AddUser(firstName, lastName);
                        Console.WriteLine();
                        break;

                    case "quit":
                        running = false;
                        break;

                    default:
                        Console.WriteLine($@"Unknown command: ""{actionToTake??""}"". Enter ""quit"" to exit. ");
                        break;
                }
            } while (running);
        }
    }
}
