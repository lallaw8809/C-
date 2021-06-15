using System;

public class Example
{
    public static void DifferentWayToInitializeString()
    {
        // Declare and initializing string
        string str1 = "Hello Phonak";
        String str2 = "Hello world";

        // Initialize string with empty string
        string str3 = String.Empty;

        // Initialize the string with null
        String str4 = null;

        // Create a string from array of char
        char[] name = { 'L', 'A', 'L' };
        string str5 = new string(name);

        Console.WriteLine("Declare a string with \"string\":" + str1);
        Console.WriteLine("Declare a string with \"String\":" + str2);
        Console.WriteLine("Initialize the string with \"String.Empty\":" + str3);
        Console.WriteLine("Initialize the string with \"null\":" + str4);
        Console.WriteLine("Initialize the string with \"array\":" + str5);
        Console.WriteLine();
    }

    public static void StringRegular()
    {
        string nativePlace = "Welcome to \"KanyaKumari, India\"";
        Console.WriteLine(nativePlace);
        Console.WriteLine();
    }

    public static void stringVerbatim()
    {
        string path = @"C:\Users\Lal\Documents\";
        Console.WriteLine(path);

        string str1 = @"Hi All,
                        We are larning ...
                        string verbatim";
        Console.WriteLine(str1);

        string str2 = @"My name is ""Lal Bosco.""";
        Console.WriteLine(str2);
        Console.WriteLine();
    }
    public static void stringProperties()
    {
        string property = "There are two properties in string that are 1. Chars 2. Length ;";

        int stringLength = property.Length;

        for (int i = 0; i < stringLength; i++)
        {
            if (Char.IsDigit(property[i]))
                Console.WriteLine("This charact is a digit : " + property[i]);
            //else if (Char.IsWhiteSpace(property[i]))
            //    Console.WriteLine("This charact is a WhiteSpace : " + property[i]);
            else if (Char.IsPunctuation(property[i]))
                Console.WriteLine("This charact is a Punctuation : " + property[i]);
            else if (Char.IsPunctuation(property[i]))
                Console.WriteLine("This charact is a Punctuation : " + property[i]);

            // this is the way we can check small or captital letters as well by using
            // the Char.IsUpper(property[i])) and Char.IsLower(property[i]))
        }
        Console.WriteLine("String Length : " + property.Length);
        Console.WriteLine();
    }

    public static void stringMethod()
    {
        string str1 = "Hello world";
        string str2 = "My name is Lal";
        string str3 = string.Concat(str1, str2);
        string str4 = (String)str1.Clone();
        string str5 = string.Copy(str2);
        string str6 = str1.Insert(3, "Lal");
        string str7 = str1.Replace("world", "Lal Bosco");

        Console.WriteLine("string.ToLower(): " + str1.ToLower()); // hello world
        Console.WriteLine("string.ToUpper(): " + str1.ToUpper()); //  HELLO WORLD
        Console.WriteLine("string.Concat(): " + str3); // Hello worldMy name is Lal
        Console.WriteLine("string.Clone(): " + str4); // Hello world
        Console.WriteLine("string.Contains(): " + str1.Contains("world")); // True
        Console.WriteLine("string.Copy(): " + str5); //My name is Lal
        Console.WriteLine("string.Equals(): " + str1.Equals(str2)); // False
        Console.WriteLine("string.IndexOf(): " + str1.IndexOf('o')); // 4
        Console.WriteLine("string.Insert(): " + str6); // HelLallo world
        Console.WriteLine("string.Replace(): " + str7); //Hello Lal Bosco
        Console.WriteLine("string.Substring(): " + str1.Substring(2)); // llo world
        Console.WriteLine("string.Trim(): " + str1.Trim()); // Hello world
        Console.WriteLine();
    }

    public static void Main()
    {
        Console.WriteLine("Different Ways of string intitialization");
        DifferentWayToInitializeString();

        Console.WriteLine("String Regular");
        StringRegular();

        Console.WriteLine("String Verbatim");
        stringVerbatim();

        Console.WriteLine("String Properties");
        stringProperties();

        Console.WriteLine("String Method");
        stringMethod();
    }
}