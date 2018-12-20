/* Display a text file.
To use this program, specify the name of the file that you
want to see. For example, to see a file called TEST.CS,
use the following command line.
ShowFile TEST.CS
*/
using System;
using System.IO;

class ShowFile
{
    static void Main(string[] args)
    {
        int i;
        FileStream fin;
        
     
        try
        {
            fin = new FileStream("ErrOut.cs", FileMode.Open);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Cannot Open File");
            Console.WriteLine(exc.Message);
            return; // File can't be opened, so stop the program.
        }
        // Read bytes until EOF is encountered.
        try
        {
            do
            {
                i = fin.ReadByte();
                if (i != -1) Console.Write((char)i);
            } while (i != -1);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error Reading File");
            Console.WriteLine(exc.Message);
        }
        finally
        {
            fin.Close();
        }
    }
}