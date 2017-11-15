using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;

namespace CryEngineProjectConverter
{
    public class Converter
    {
        private Project projectFile;
        private const string pathCsproj = "Game/Game.csproj";
        private const string pathSln = "Game.sln";

        public Converter()
        {
            projectFile = new Project();
        }

        public void Start()
        {
            ConvertCSPROJ();
            ConvertSLN();
        }

        private void ConvertCSPROJ()
        {
            //()<Proje?t*.+?<.+ 

            string input = File.ReadAllText(pathCsproj);

#if DEBUG
            Console.WriteLine(input);
#endif

            string pattern = "()<ProjectTypeGuids.+?<.+";
            string replacement = "<ProjectTypeGuids>{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>";
            input = Regex.Replace(input, pattern, replacement);

            
            //pattern = "()<ProjectGuid.+?<.+";
            //replacement = "<ProjectGuid>7B3F1234-1CFE-4CCF-B1CB-12345F8606F1</ProjectGuid>";
            //input = Regex.Replace(input, pattern, replacement);

#if DEBUG
            Console.WriteLine(input);
#endif

            File.WriteAllText(pathCsproj, input);

            
            //newProjectGuid.InnerText = "7B3F1234-1CFE-4CCF-B1CB-12345F8606F1";
            //newProjectTypeGuids.InnerText = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
        }

        private void ConvertSLN()
        {
            string input = File.ReadAllText(pathSln);

#if DEBUG
            Console.WriteLine(input);
#endif

            string pattern = "(){(?:1).+?}";
            string replacement = "{7B3F1234-1CFE-4CCF-B1CB-12345F8606F1}";
            MatchCollection result = Regex.Matches(input, pattern);
            input = Regex.Replace(input, pattern, replacement);

            File.WriteAllText(pathSln, input);

#if DEBUG
            Console.WriteLine(input);
#endif


            
        }
    }
}
