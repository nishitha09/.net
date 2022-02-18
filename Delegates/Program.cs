using System;

namespace Exercises
{
    class Delegates
    {
        delegate string UppercaseDelegate(string input);
        static string UppercaseFirst(string input)
        {
            Char[] buffer = input.ToCharArray();
            buffer[0] = Char.ToUpper(buffer[0]);
            return new string(buffer);
        }
        static string UppercaseLast(string input)
        {
            Char[] buffer = input.ToCharArray();
            buffer[buffer.Length - 1] = Char.ToUpper(buffer[buffer.Length - 1]);
            return new string(buffer);
        }
        static string UppercaseAll(string input)
        { 
            return input.ToUpper();
        }
        static void WriteOutput(string input, UppercaseDelegate del)
        {
            Console.WriteLine("Input string:{0}", input);
            Console.WriteLine("output string:{0}",del(input));
        }
        static void Main()
        { 
            WriteOutput("tom",new UppercaseDelegate(UppercaseFirst));
            WriteOutput("tom",new UppercaseDelegate(UppercaseLast));
            WriteOutput("tom",new UppercaseDelegate(UppercaseAll));
            Console.ReadLine();
        }
    }
}
