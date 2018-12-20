/* Use LastModified.
To see the date on which a website was last modified, enter its URI on the commandline. For example, if you call this program LastModifiedDemo, then to see the date of lastmodification for HerbSchildt.com enter
LastModifiedDemo http://www.HerbSchildt.com
*/
using System;
using System.Net;
class LastModifiedDemo
{
    static void Main(string[] args)
    {
        //if (args.Length != 1)
        //{
        //    Console.WriteLine("Usage: LastModifiedDemo <uri>");
        //    return;
        //}

        HttpWebRequest req = (HttpWebRequest)
        WebRequest.Create("http://www.HerbSchildt.com");
        HttpWebResponse resp = (HttpWebResponse)
        req.GetResponse();
        Console.WriteLine("Last modified: " + resp.LastModified);
        resp.Close();
    }
}
