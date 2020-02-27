using System;
using System.IO;

namespace fileshandle
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream myFile = new FileStream("data.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i<=10; i++)
            {
                myFile.WriteByte((byte)i);
            }
            // Read the stream
            myFile.Position = 0;
            for (int x = 0; x<=10; x++)
            {
                System.Console.WriteLine(myFile.ReadByte() + "");
            }
            myFile.Close();

            // append multi string to names.txt text file
            string multi = "Will" + Environment.NewLine + "Peter" + Environment.NewLine + "Joe";
            File.AppendAllLines("names.txt", multi.Split(Environment.NewLine.ToCharArray()));

            // append string
            File.AppendAllText("myFile.txt", "Add this string to text file");
            // replace all text in file
            File.WriteAllText("myFile.txt", "Replacing all text");
            // static tools
            bool fileExist = File.Exists("myFile.txt");
            System.Console.WriteLine("does file exist: {0}", fileExist);

            // copy file - check newFile exists first
            // File.Copy("myFile.txt", "newFile.txt");

            // check last time file was accessed
            DateTime lastopened = File.GetLastAccessTime("myFile.txt");
            System.Console.WriteLine(lastopened);
            // last write time
            DateTime lastwrite = File.GetLastWriteTime("myFile.txt");
            System.Console.WriteLine(lastwrite);

            // move file one directory up
            // File.Move("newFile.txt", "../newFile.txt"); 


            // put it together
            // write file
            string path = "/tmp/makeFile.txt";
            if (!File.Exists(path))
            {
                // create file
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("Hello ");
                    sw.Write("World ");
                    sw.Write("Welcome to my file");
                }
            }

            // read file
            try {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string line; 
                        while ((line = sr.ReadLine()) !=null)
                        {
                            System.Console.WriteLine(line);
                        }
                    }
                }
            } catch(Exception exception) {
                System.Console.WriteLine("Could not read file:");
                System.Console.WriteLine(exception.Message);
            }

            // binary read write
            BinaryWriter bw;
            BinaryReader br;
            // data to put into file
            int d = 42;
            double pi = 3.14159;
            bool bval = true;
            string myString = "Hello World";
            // make file
            try 
            {
                bw = new BinaryWriter(new FileStream("/tmp/bin-data.txt", FileMode.Create));
            } 
            catch(IOException exception) 
            {
                System.Console.WriteLine(exception.Message + "\nUnable"+ 
                "to create file");
                return;
            }
            // write data
            try
            {
                bw.Write(d);
                bw.Write(pi);
                bw.Write(bval);
                bw.Write(myString);
            }
            catch(IOException exception)
            {
                System.Console.WriteLine(exception.Message + "Unable to write data");
                return;
            }
            bw.Close();
            // read from bin file
            try
            {
                br = new BinaryReader(new FileStream("/tmp/bin-data.txt", FileMode.Open));
            } 
            catch(IOException exception)
            {
                System.Console.WriteLine(exception.Message + "\nUnable to open file");
                return;
            }
            
            int myint = 42;
            double mypi = 3.14159;
            bool mybval = true;
            string getmyString = "Hello World";


            try
            {
                myint = br.ReadInt32();
                mypi = br.ReadDouble();
                mybval = br.ReadBoolean();
                getmyString = br.ReadString();
                System.Console.WriteLine("My integer: {0}", myint);
                System.Console.WriteLine("My double: {0}", mypi);
                System.Console.WriteLine("My bool: {0}", mybval);
                System.Console.WriteLine("My string: {0}", getmyString);
            }
            catch(IOException exception)
            {
                System.Console.WriteLine(exception.Message + "\nUnable to read from file");
                return;
            }
            br.Close();

            

        } 
    }
}
