/* Copy a file using File.Copy().
To use this program, specify the name of the source
file and the destination file. For example, to copy a
PART I
Chapter 14:  Using I/O  405
PART I
file called FIRST.DAT to a file called SECOND.DAT, use
the following command line:
CopyFile FIRST.DAT SECOND.DAT
*/
using System;
using System.IO;
class CopyFile1
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: CopyFile From To");
            return;
        }
        // Copy the files.
        try
        {
            File.Copy(args[0], args[1]);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error Copying File\n" + exc.Message);
        }
    }
}