using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApplication1
{
    class serialization_in_c_sharp
    {
        [Serializable]
        public class UserPrefs
        {
            public string WindowColor;
            public int FontSize;
        }

        static void Main(string[] args)
        {
            UserPrefs userData = new UserPrefs();
            userData.WindowColor = "Yellow";
            userData.FontSize = 50;
            // The BinaryFormatter persists state data in a binary format.
            // You would need to import System.Runtime.Serialization.Formatters.Binary
            // to gain access to BinaryFormatter.
            BinaryFormatter binFormat = new BinaryFormatter();
            // Store object in a local file.
            using (Stream fStream = new FileStream("user.dat",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, userData);
            }
            Console.ReadLine();

            LoadFromBinaryFile("user.dat");
            
        }

        static void LoadFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            // Read the JamesBondCar from the binary file.
            using (Stream fStream = File.OpenRead(fileName))
            {
                UserPrefs carFromDisk =
                (UserPrefs)binFormat.Deserialize(fStream);

                Console.WriteLine("Can this car fly? : {0}   {1}", carFromDisk.WindowColor,carFromDisk.FontSize);
            }
        }
    }
}



