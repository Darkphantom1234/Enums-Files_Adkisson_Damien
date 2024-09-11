using System;
using System.IO;


namespace Enums_Files_Adkisson_Damien
{

    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Nov,
        Dec,
    }
    class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Dec;
            int myBirthDay = 23;
            int myBirthYear = 1997;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", myBirthDate);
                Console.WriteLine(File.ReadAllText("newFile.txt"));
            }
        }
    }
}