using System;
using System.Linq;
using System.Collections.Generic;

namespace _03extractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int lastSeparatorIndex = path.LastIndexOf('\\');
            int extensionIndex = path.LastIndexOf('.');


            if (lastSeparatorIndex != -1 && extensionIndex != -1 &&
                extensionIndex > lastSeparatorIndex)
            {
                fileName = path.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);
                fileExtension = path.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}