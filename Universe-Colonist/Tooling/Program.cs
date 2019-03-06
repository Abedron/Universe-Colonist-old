using CLI;
using System;
using System.Threading.Tasks;
using Tooling.DefinitionLoaderTool;

namespace Tooling
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var command = Console.ReadLine();
            // if (command == "def")
            {
                var definitionLoader = new DefinitionLoader();
                definitionLoader.LoadAll();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\nLoaded {definitionLoader.CountDefinitions} definitions");
            }

            Console.ReadLine();
        }
    }
}
