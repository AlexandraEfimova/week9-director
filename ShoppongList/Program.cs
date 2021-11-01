﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppongList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Alexandra\Downloads\programm";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();

            if (Directory.Exists($"{rootDirectory}\\{ newDirectory}") && File.Exists($"{rootDirectory}\\{ newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory {newDirectory} and file {fileName} exists at {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{ newDirectory}");
                File.Create($"{rootDirectory}\\{ newDirectory}\\{fileName}");
            }

        }
    }
}
