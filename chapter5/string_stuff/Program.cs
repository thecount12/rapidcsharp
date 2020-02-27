using System;
// pick out portions of the code to uncomment
namespace string_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            /* convert to char */
            // char[] name_array = {'W', 'i', 'l', 'l','i', 'a', 'm'};
            // string name_convert = new string(name_array);
            // Console.WriteLine(String.Format("My name is: {0}", name_convert));
        
            /* string manipulation */
            
            /* length */        
            // string first_name = "William";
            // string last_name = "Gunnells";
            // int first = first_name.Length;
            // int last = last_name.Length;
            // Console.WriteLine(String.Format("First Name: {0}, Character count {1}", first_name, first));
            // Console.WriteLine(String.Format("Last Name: {0}, Character count {1}", last_name, last));
            // string full_name = String.Concat(first_name, " ", last_name);
            // Console.WriteLine(String.Format("Full name: {0}", full_name));
            
            /* Join */
            // string [] array_of_names = {"William", "Peter", "Bob"};
            // string long_names = String.Concat(array_of_names);
            // Console.WriteLine(String.Format("Joined names: {0}", long_names));
        
            /* ToUpper() */
            // string first_name = "William";
            // Console.WriteLine(String.Format("ToUpper: {0}", first_name.ToUpper()));
            

            /* ToLower() */
            // Console.WriteLine(String.Format("ToLower: {0}", first_name.ToLower()));

            /*  Trim()*/
            // string name = "   William  ";
            // Console.WriteLine(String.Format("Trim name: {0}", name.Trim()));

            /* Contains() */
            // string message = "Hello World";
            // bool IsPresent = message.Contains("World");
            // Console.WriteLine(String.Format("Contains World: {0}", IsPresent));


            /* IndexOf() */
            // char find_char = 'l';
            // string new_name = "iam";
            // int position = first_name.IndexOf(find_char);
            // int name_position = first_name.IndexOf(new_name);
            // Console.WriteLine(position);
            // Console.WriteLine(name_position);

            /* LastIndexOf() */

            /*  Replace() */
            // string message = "Hello World";
            // message = message.Replace("World", "William");
            // Console.WriteLine(message);


            /* StartsWidth() */

            // string message = "Hello World";
            // Console.WriteLine(message.StartsWith("Hello"));

            /* EndsWith() */

            // string message = "Hello World";
            // Console.WriteLine(message.EndsWith("Hello"));

            /* Substring() */

            // string message = "Hello World";
            // Console.WriteLine(message.Substring(6));

            /* Compare() */

            // string message1 = "Hello";
            // string message2 = "H3llo";
            // bool match = string.Compare(message1, message2) == 0;
            // Console.WriteLine(match);

            /* Equals() */

            // string message1 = "Hello";
            // string message2 = "H3llo";
            // bool match = string.Equals(message1, message2);
            // Console.WriteLine(match);

            /* Insert() */

            // string name = "William Gunnells";
            // string full_name = name.Insert(8, "C ");
            // Console.WriteLine(full_name);

            /* Remove() */
            // string name = "William Gunnells";
            // string full_name = name.Remove(7);
            // Console.WriteLine(full_name);

            /* ToCharArray() */
            // string name = "William";
            // char [] name_array = name.ToCharArray();
            // for (int x=0; x < name_array.Length; x++)
            // {
            //     Console.WriteLine(name_array[x]);
            // }
            /* Split() */

            // string name = "William C Gunnells";
            // string [] split_name = name.Split(new char[] {' '});
            // for (int i =0; i< split_name.Length; i++)
            // {
            //     Console.WriteLine(split_name[i]);
            // }

        }


    }
}
