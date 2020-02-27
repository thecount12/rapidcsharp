using System;
using System.Text.RegularExpressions;

namespace regexstuff
{
    class Program
    {
        private static void getMatch(string input, string expression)
        {
            System.Console.WriteLine("The Expression is: " + expression);
            var mc = Regex.Matches(input, expression);

            // MatchCollection mc = Regex.Matches(input, expression);
            // foreach (Match i in mc)
            // {
            //     System.Console.WriteLine(i);
            // }
            for (int i=0; i< mc.Count; i++)
            {
                System.Console.WriteLine(mc[i]);
            }
        }
        static void Main(string[] args)
        {
            string myString = "Lets split this string into substrings";
            System.Console.WriteLine("Words that begin with s");
            getMatch(myString, @"\bs\S*");
            getMatch(myString, @"\bs\S*t\b");
            patternReplace("Oh this interesting", "\\s+", ""); // whitespace
            patternReplace("Oh this     interesting", "\\s+", " "); // whitespace
            patternReplace("Oh this interesting", "\\binteresting\\b", "cool");

        }
        static void patternReplace(string inputText, string replacePattern, string subText)
        {
            Regex rep = new Regex(replacePattern);
            string newOutput = rep.Replace(inputText, subText);
            System.Console.WriteLine("Original String is: {0}", inputText);
            System.Console.WriteLine("modified String is: {0}", newOutput);
        }
    }
}
