using System;
using System.Data;
using System.Media;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
             // int
            int myInt = 12345678;
            myInt.DisplayAssembly();

            #region More Examples
            
            // DataSet
            DataSet myDataSet = new DataSet();
            myDataSet.DisplayAssembly();

            // SoundPlayer
            SoundPlayer mySoundPlayer = new SoundPlayer();
            mySoundPlayer.DisplayAssembly();

            // DateTime
            DateTime date = new DateTime();
            date.DisplayAssembly();

            // String
            string myString = "CD";
            myString.DisplayAssembly();

            #endregion

            // Use new integer functionality.
            Console.WriteLine("Value of myInt:           {0}", myInt);
            Console.WriteLine("Reversed digits of myInt: {0}", myInt.ReverseDigits());

            Console.ReadLine();
        }
    }
}
