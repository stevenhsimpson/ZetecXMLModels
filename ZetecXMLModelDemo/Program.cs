using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZetecXMLModels;

namespace ZetecXMLModelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ZetecModel zm = XMLModelReader.ReadZetecModel(@"c:/data/BGA-33110-SG.xml");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("Utility Name: {0}", zm.VesselInformation.UtilityName);
            Console.WriteLine("Vessel Name: {0}", zm.VesselInformation.ComponentName);
            Console.WriteLine("Unit: {0}", zm.VesselInformation.Unit);
            Console.WriteLine("Tubes read: {0}" ,zm.Tubes.Count);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            Console.ReadKey();

        }
    }
}
