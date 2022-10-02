using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadingFromTextFiles();

            WritingToTextFiles();


            string stations = File.ReadAllText("stations.txt");

            // this isn't VS.Code/dotnet.Core so read the key 
            Console.ReadKey();
        }

        private static void WritingToTextFiles()
        {
            // the stringbuilder is more efficient that using the + to join strings together 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("line 1");
            int x = 2;
            sb.Append($"line {x}");

            // option 1 - dump it out all in one go
            File.WriteAllText("outputfile.txt", sb.ToString());

            // the "." path is the current directory, ".." is the parent 
            // this could be an absolute path 
            string docPath = ".";
            List<string> lines = new List<string> { "some", "text", "to", "add", "one item per line" }; 

            // an alternative use for 'using' - this deals with closing nicely 
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "writeLines.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

            // an alternative place            
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private static void ReadingFromTextFiles()
        {
            // option 1 - grab it all 
            string s = File.ReadAllText("textfile.txt");
            Console.WriteLine(s);

            // option 2 - line by line - note the use of using here 
            using (StreamReader sr = new StreamReader("testFile.txt"))
            {
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
    }
}
