using System;
using System.IO;


namespace Enums___Files_Adkisson_Damien
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

            File.WriteAllText("myFile.txt", "This is my text file!");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
        }
    }
}