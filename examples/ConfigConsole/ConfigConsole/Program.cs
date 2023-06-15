using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

            // 1a you could leave it in MyDocuments 
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"));

            // But then where does the filename come from? 

            // option 2. go to the Project name in the Soluton Explorer - double click > Settings 

            // you will see that there are some already available - 
            int x = Properties.Settings.Default.MySettingValue;

            // Application Settings are immutable, so if you uncomment this, you'll get a red squiggly line ... 
            // Properties.Settings.Default.MySettingValue = 76;

            // but User settings are not
            string val = Properties.Settings.Default.ChangableSetting;
            Properties.Settings.Default.ChangableSetting = "new value";
            Properties.Settings.Default.AnotherUserSetting = -1.23m;

            // NB properties are stored in the app.config file as strings 

            // option 3 Also in app.config you have a list of <string, string> key-value pairs
            string key = "setting";
            var from_app_setting = ConfigurationManager.AppSettings[key];

            // 4. and you have the command line 
            // you can iterate through the args parameter 
            foreach (string p in args)
                Console.WriteLine(p);

            // you can test this using Properties > Debug to pass this in to VS 

            // and there are specific tools to parse the command line into an object, e.g. https://www.nuget.org/packages/CommandLineParser 


            // option 5 - in Windows GUIs you have the dialog boxes, including OpenFileDialog, to gain user input ... 
        }
    }
}
