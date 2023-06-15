using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // option 1 - add a file to the project, set its Output to property to Always 
            string filename = "MyTextFile.txt";
            string fromAFile = System.IO.File.ReadAllText(filename);

            // But then where does the filename come from? 

            // go to the Project name in the Soluton Explorer - double click > Settings 

            // you will seel that there are some already available - 
            int x = Properties.Settings.Default.MySettingValue;

            // Application Settings are immutable, so if you uncomment this, you'll get a red squiggly line ... 
            // Properties.Settings.Default.MySettingValue = 76;

            // but User settings are not
            string val = Properties.Settings.Default.ChangableSetting;
            Properties.Settings.Default.ChangableSetting = "new value";
            Properties.Settings.Default.AnotherUserSetting = -1.23m;

            // NB properties are stored in the app.config file as strings 

            // Also in app.config you have a list of <string, string> key-value pairs
            string key = "setting";
            var from_app_setting = ConfigurationManager.AppSettings[key];

            // and finally you have the command line 
            // you can iterate through the args parameter 
            foreach (string p in args)
                Console.WriteLine(p);

            // you can test this using Properties > Debug to pass this in to VS 

            // and there are specific tools to parse the command line into an object, e.g. https://www.nuget.org/packages/CommandLineParser 

        }
    }
}
