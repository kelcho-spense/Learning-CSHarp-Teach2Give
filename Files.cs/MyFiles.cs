using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files.cs
{
    public class MyFiles
    {
        public void ExecuteMyFiles()
        {
            // create a DIR
            string dir = @"C:\Videos\MyDir";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // create a file
            string file1 = @"C:\Videos\MyDir\MyFile.txt";
            string file2 = @"C:\Videos\MyDir\MyFile2.txt";
            if (!File.Exists(file1))
            {
                File.Create(file1);
            }
            if (!File.Exists(file2))
            {
                File.Create(file2);
            }

            // list files in a DIR
            string[] files = Directory.GetFiles(dir);
            foreach (string f in files)
            {
                Console.WriteLine($"file: {f}");
            }

            //write to a file
            string[] lines = { "First line", "Second line", "Third line" };
            File.WriteAllLines(file1, lines);

            var mytext = "This is my text";

            File.WriteAllText(file2, mytext);

            //read from a file
            Console.WriteLine("reading from file1");
            string[] readLines = File.ReadAllLines(file1);
            foreach (string line in readLines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("reading from file2");
            string readText = File.ReadAllText(file2);
            Console.WriteLine(readText);

            // copy a file
            string file3Destination = @"C:\Videos\MyDir\MyFile5.txt";
            if (File.Exists(file3Destination))
            {
                File.Delete(file3Destination);
            }

            File.Copy(file1, file3Destination);

            Console.WriteLine("display content of a copied file");
            string[] readLines1 = File.ReadAllLines(file3Destination);
            foreach (string line in readLines1)
            {
                Console.WriteLine(line);
            }


            //append more text to a file

            string[] lines2 = { "Fourth line", "Fifth line", "Sixth line" };
            File.AppendAllLines(file3Destination, lines2);

            Console.WriteLine("display content of a copied & appended file");
            string[] readLines2 = File.ReadAllLines(file3Destination);
            foreach (string line in readLines2)
            {
                Console.WriteLine(line);
            }

            //move  file file3Destination to another DIR using move method

            string newfiledestination = @"C:\Videos\MyDir2\MyFile5.txt";
            if (File.Exists(newfiledestination))
            {
                Console.WriteLine("The file exist");
            } else
            {
            File.Move(file3Destination, newfiledestination);
                Console.WriteLine("file moved successfully");
            }

            //get file info
            FileInfo fileInfo = new FileInfo(newfiledestination);
            Console.WriteLine($"file name: {fileInfo.Name}");
            Console.WriteLine($"file size: {fileInfo.Length}");
            Console.WriteLine($"file extension: {fileInfo.Extension}");
            Console.WriteLine($"file created: {fileInfo.CreationTime}");
            Console.WriteLine($"file last accessed: {fileInfo.LastAccessTime}");

            //file attributes
            FileAttributes fileAttributes = File.GetAttributes(newfiledestination);
            if ((fileAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Console.WriteLine("file is read only");
            }
            else
            {
                Console.WriteLine("file is not read only");
            }

            //set read only attribute to a file
            File.SetAttributes(newfiledestination, FileAttributes.ReadOnly);

            
         










        }
    }
}
