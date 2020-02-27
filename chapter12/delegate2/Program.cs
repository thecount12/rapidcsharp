using System;
using System.IO;

namespace delegate2
{
    class Program
    {
        static FileStream fileStream;
        static StreamWriter streamWriter;
        // delegate an object
        public delegate void PrintString(string str1);
        // to screen
        public static void WriteConsole(string str2)
        {
            System.Console.WriteLine("My String is: {0}", str2);
        }
        // to file
        public static void WriteFile(string str1) 
        {
            fileStream = new FileStream("message.txt", 
            FileMode.Append, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(str1);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        // delegate as paramater to call methods
        public static void sendToLog(PrintString ps)
        {
            ps("Boom!");
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            PrintString ps1 = new PrintString(WriteConsole);
            PrintString ps2 = new PrintString(WriteFile);
            sendToLog(ps1);
            sendToLog(ps2);
        }
    }
}
