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

                Console.WriteLine("Loaded All");
            }

            Console.ReadLine();
        }
    }
}
