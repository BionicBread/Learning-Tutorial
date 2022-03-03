using System.IO;
using System.Text;
namespace Sandbox1
{
    partial class Program
    {
        public class FileStreamExample 
        {
            public void StreamAFile()
            {
                string path = @"D:\fileStreamTest\someFile.txt";

                FileStream fileStream = File.Create(path);
                
                AddText(fileStream, "this is some text ");
                AddText(fileStream, "this is some more text ");
                AddText(fileStream, "this is some text\n with a line break");
                
            }
            public void AddText(FileStream fs, string value)
            {
                byte[] info = new UTF8Encoding(true).GetBytes(value);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
