using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryEngineProjectConverter
{
    class Validator
    {
        public static bool IsExecuteInTheCorrectFolder()
        {
            bool correct = false;

            if (File.Exists("Game.sln"))
            {
                if (File.Exists("Game/Game.csproj"))
                {
                    correct = true;
                }
                else
                    Console.WriteLine("can't find Game.csproj");
            }
            else
            {
                Console.WriteLine(@"
can't find Game.sln
you are in the wrong folder or the project was not generated
");
            }

            return correct;
        }
    }
}
