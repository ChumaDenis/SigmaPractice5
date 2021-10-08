using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Program
{
    static void Main(string[] args)
    {
        string path = @"";
        path = Console.ReadLine();
        string[] temp = Path.GetFileName(path).Split('.');
        string name = temp[0];
        string directory = Directory.GetDirectoryRoot(path);
        Console.WriteLine("File name: {0}", name);
        Console.WriteLine("Directory: {0}", directory);
    }
}
