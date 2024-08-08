using System;
using System.IO;
using System.Text;

class DeleteFile
{
    public static void Main()
    {
        string fileName = @"testfile.txt";

        Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");
        Console.Write("--------------------------------------------------------------\n");

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine(" The file {0} deleted successfully.\n\n", fileName);
        }
        else
        {
            Console.WriteLine(" File does not exist");
            Console.ReadKey();
        }
    }
}