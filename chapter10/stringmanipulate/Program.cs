using System;
using System.Text;

namespace stringmanipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder sb = new StringBuilder();
            // sb.Append("Add text and numbers").Append(": 5, here");
            // System.Console.WriteLine(sb.ToString());

            //System.Console.WriteLine(testManualconcat('w', 20));
            // DateTime start = DateTime.Now;
            // string testSPeed = testManualconcat('w', 100000);
            // DateTime end = DateTime.Now;
            // System.Console.WriteLine(end - start);

            // DateTime start = DateTime.Now;
            // string testSPeed = testStringBuild('w', 100000);
            // DateTime end = DateTime.Now;
            // System.Console.WriteLine(end - start);

        }

        static string testManualconcat(char myConcat, int count)
        {
            string joinString = "";
            for (int i = 0;  i < count; i++)
            {
                joinString += myConcat;
            } 
            return joinString;

        }
        static string testStringBuild(char myConcat, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0;  i < count; i++)
            {
                sb.Append(myConcat);
            } 
            return sb.ToString();
        }
    }
}
