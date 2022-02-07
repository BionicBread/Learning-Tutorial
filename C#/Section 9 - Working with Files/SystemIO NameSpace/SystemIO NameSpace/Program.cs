using System;
using System.IO;

namespace SystemIO_NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Useful classes and methods in system.io namespace
            // File, Fileinfo
            // provides methods for creating, copying, deleting, moving and opening of files
            // Fileinfo - provides instanced methods: only one security check for an instanced method. Ideal for large number of files.
            // File - provides static methods: security permission checks for each execution of the file method. Ideal for small numbers of files
            // SOME METHODS:
            // Create()
            // Copy()
            // Delete()
            // Exists()
            // GetAttributes()
            // Move()
            // ReadAllText()

            // Directory, DirectoryInfo
            // provides methods for dealing with directories
            // Directory - provides static methods
            // DirectoryInfo - provies instance methods
            // SOME METHODS
            // CreateDirectory()
            // Delete()
            // Exists()
            // GetCurrentDirectory()
            // GetFiles() // can be used with extentions i.e get all files that has a jpg extention 
            // Move()
            // GetLogicalDrives()

            // Path 
            // Contain methods that works with a string that contains a file or directory path information
            // SOME METHODS
            // GetDirectoryName()
            // GetFileName()
            // GetExtension() // gets only the extension part of a path
            // GetTempPath() // returns path of temp folder

            ////////////////DEMO FILE AND FileInfo//////////////////////
            /// .FILE
            /// Static
            string path = @"C:\temp\somePic.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp1\myfile.jpg", true); // boolen set to true will overwrite

            File.Delete(path);
            if (File.Exists(path))
            {
                //DO SOMETHING
            }

            var content = File.ReadAllText(path); // read all text in a file returns a string
            File.ReadAllBytes(path); // read a file as binary

            // .FILEINFO 
            // non static so create an object for instance methods

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...."); // copy to some path
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            ////////////////Directory and DirectoryInfo///////////////////
            /// Directory
            /// static
            /// 

            Directory.CreateDirectory(@"C:\temp\folder1"); // creates a directory 

            // get FILES
            string[] files = Directory.GetFiles(@"C:\temp", "*.*", SearchOption.AllDirectories); // 3 overloads for searching and extention - *.* means all files this is a search pattern
            foreach (var file in files)                                                                  // returns a string array, the name of all files found can be displayed in a foreach loop
            {
                Console.WriteLine(file);
            }
            string[] files2 = Directory.GetFiles(@"C:\temp", "*.sln", SearchOption.AllDirectories); // changed to only search for .sln extention
            foreach (var file in files2)                                                                  
            {
                Console.WriteLine(file);
            }

            // get DIRECTORIES

            string[] directories = Directory.GetDirectories(@"C:\temp", "*.*", SearchOption.AllDirectories); // search all directories in the path

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            // Exist 
            Directory.Exists("....."); //does directory exist

            /// DirectoryInfo
            /// non static
            /// need to instantisate the method 
            var directoryInfo = new DirectoryInfo("....");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories(); // WORKS THE SAME AS ABOVE







        }
    }
}
