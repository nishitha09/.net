﻿using System;
using System.IO;


namespace Exercises
{
    class FlieRead
    {
        public static void Main()
        {
            string fileName;
            while (true)
            {
                Console.WriteLine("\n___Menu___\n");
                Console.WriteLine("\n 1.Create a file");
                Console.WriteLine("\n 2.Existence of file");
                Console.WriteLine("\n 3.Read the content of the file");
                Console.WriteLine("\n 4.Exit");
                Console.WriteLine("\n Enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("\n Enter the file name to create:");
                        fileName = Console.ReadLine();
                        Console.WriteLine("\n Write the contents to the file\n");
                        string r = Console.ReadLine();
                        using (StreamWriter fileStr = File.CreateText(fileName))
                        {
                            fileStr.WriteLine(r);
                        }
                        Console.WriteLine("File is created");
                        break;
                    case 2:
                        Console.Write("Enter the file name to read the contentrs :\n");
                        fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            Console.WriteLine("File exist");
                        }
                        else
                        {
                            Console.WriteLine("File doesnot exist in the current directory!");
                        }
                        break;
                    case 3:
                        Console.Write("Enter the fileName to read the contents:\n");
        
                             fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            using (StreamReader sr = File.OpenText(fileName))
                            {
                                string s = "";
                                Console.WriteLine("Here is the content of file:");
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.WriteLine("File doesnot exists");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n Existing___");
                   return;
                    default:
                        Console.WriteLine("\n Invalid choice");
                        break;
                }
            }
        }
    }
}