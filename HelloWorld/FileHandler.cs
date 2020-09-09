/*
 * A library of utility functions for efficient handling of file IO
 * Provides features such as clearing the file, writing files at each line, etc
 * Made by Gavin Wu
 * 09/09/2020
 */

using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

using System.Security.Permissions;

namespace HelloWorld
{
    class FileHandler
    {
        public string text = "This is a test";
        private string path;
        // private List<string> fileContents = new List<string>();
        // CONSTRUCTOR METHOD
        public FileHandler(string path)
        {
            this.path = path;
        }


        // Method to return contents of file as a list of strings, for each line.
        public List<string> getFileContentsArray()
        {
            List<string> fileContents = new List<string>();
            fileContents.Clear();
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        fileContents.Add(s);
                    }
                }

            }
            else
            {
                Console.WriteLine("getFileContentsArray error - File not found at path: " + path);
            }  

            return fileContents;
        }

        // Clears file and writes the string array to file.
        public void appendStringLineArray(List<string> strList)
        {
            if (File.Exists(path))
            {
                for (int i = 0; i < strList.Count; i++)
                {
                    appendStringLine(strList[i]);
                }
            }
            else
            {
                Console.WriteLine("appendStringLineArray error - File not found at path: " + path);
            }
        }

        // Clears file and writes the string array to file.
        public void clearAndWriteStringArray(List<string> strList)
        {
            if (File.Exists(path))
            {
                clearFile();
                for (int i = 0; i < strList.Count; i++)
                {
                    appendStringLine(strList[i]);
                }
            }
            else
            {
                Console.WriteLine("clearAndWriteStringArray error - File not found at path: " + path);
            }
        }

        // Write the string to the end of the file
        public void appendStringLine(string str)
        {
            if (File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("appendStringLine error - File not found at path: " + path);
            }
        }

        // Write the string to the end of the file
        public void appendString(string str)
        {
            if (File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(str);
                }
            }
            else
            {
                Console.WriteLine("appendString error - File not found at path: " + path);
            }
        }

        // Clears file and writes string in file.
        public void clearAndWriteString(string str)
        {
            if (File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("writeString error - File not found at path: " + path);
            }
        }

        // Clear all contents of the file (
        public void clearFile()
        {
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);
            }
            else
            {
                Console.WriteLine("clearFile error - File not found at path: " + path);
            }
        }

        // Display the contents of the file at given path
        public void displayFileContents()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

            }
            else
            {
                Console.WriteLine("displayFileContents error - File not found at path: " + path);
            }
        }
        // Set the path to the file
        public void setPath(string path)
        {
            this.path = path;
        }

        // Get the path as string
        public string getPath()
        {
            return this.path;
        }
    }
}
