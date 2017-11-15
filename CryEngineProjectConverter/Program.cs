using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace CryEngineProjectConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validator.IsExecuteInTheCorrectFolder())
            {
                Converter convert = new Converter();
                convert.Start();

            }

            //<ProjectTypeGuids>{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
            //<ProjectGuid> 7B3F1234-1CFE-4CCF-B1CB-12345F8606F1 </ProjectGuid>
        }
    }
}
