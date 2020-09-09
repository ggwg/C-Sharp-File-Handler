using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler = new FileHandler(@"C:\Users\gavwu\source\repos\HelloWorld\HelloWorld\temp\MyTest.txt");
            List<string> strList = new List<string>();
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            fileHandler.clearAndWriteStringArray(strList);
            fileHandler.appendStringLineArray(strList);

            fileHandler.appendStringLine("Trying to write THIS string to the file!");
            fileHandler.appendString("This is the second time I'm doing this!");
            fileHandler.appendString("Line 3!");
            fileHandler.appendString("Finally, the 4th line!!");
            fileHandler.displayFileContents();

            // Prevent command window from closing prematurely
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
