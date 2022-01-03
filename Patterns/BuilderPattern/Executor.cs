using LernCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BuilderExecutor : IExecutor
    {
        public void Run()
        {
            Console.WriteLine("BuilderPattern - enter ");
            Console.WriteLine("Press C for cold house");
            Console.WriteLine("Press G for good house");
            Console.WriteLine("Press the Escape (Esc) key to exit");
            ConsoleKeyInfo keyInfo;
            while(true)
            {
                keyInfo = Console.ReadKey();

                if(keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                var house = keyInfo.Key switch
                {
                    ConsoleKey.G => new BuildDirector().Make(false),
                    ConsoleKey.C => new BuildDirector().Make(true),
                    _ => null
                };

                if(house == null)
                {
                    Console.WriteLine("Action not valid. Try again..");
                }
                else
                {
                    Console.WriteLine("Build house:");
                    Console.WriteLine(house);
                }

            } 

            Console.WriteLine("BuilderPattern - exit ");            
        }
    }
}
