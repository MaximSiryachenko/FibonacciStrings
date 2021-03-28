using FibonacciStrings.BL.Interfaces;
using FibonacciStrings.BL.Managers;
using FibonacciStrings.BL.Services;
using FibonacciStringsMain.Validators;
using System;
using System.IO;
using System.Reflection;

namespace FibonacciStringsMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSwitch;
            string enteredPath;
            FileProcessingService fileProcessingServise;

            while (true) {
                Console.WriteLine("This program performs strings inversion in Fibonacci order and saves the result to the file result-date.txt\n\n");
                while (true)
                {
                    Console.WriteLine("Please select one of the items by entering the corresponding number and pressing Enter.\n");
                    Console.WriteLine("1 - Enter the name of the .txt file that is next to the .exe file of this program. (eg source.txt)\n");
                    Console.WriteLine("2 - Enter the full path to the input .txt file.\n");
                    Console.WriteLine(@"3 - Use a test dataset, which can be viewed in the Data\DataSet.txt path next to the .exe file of this program." + "\n");

                    if (int.TryParse(Console.ReadLine(), out menuSwitch) && menuSwitch >= 1 && menuSwitch <= 3)
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("MENU ITEM IS NOT CORRECT!\n \n");
                        continue;
                    }
                }

                switch (menuSwitch)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter the name of the input file in the format FileName.txt\n");
                        enteredPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Console.ReadLine());
                        if (!enteredPath.PathIsValid())
                        {
                            Console.Clear();
                            Console.WriteLine("Filename entered error! File not found.\n\n");
                            continue;
                        }
                        fileProcessingServise = new FileProcessingService(enteredPath, new FileManager());
                        fileProcessingServise.FileProcessing();
                        Console.WriteLine("\nYou can see the result in the file at the following path:\n" + 
                                           Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\result-date.txt");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter the full path to the input file.\n");
                        enteredPath = Console.ReadLine();
                        if (!enteredPath.PathIsValid())
                        {
                            Console.Clear();
                            Console.WriteLine("Filename entered error! File not found.\n\n");
                            continue;
                        }
                        fileProcessingServise = new FileProcessingService(enteredPath, new FileManager());
                        fileProcessingServise.FileProcessing();
                        Console.WriteLine("\nYou can see the result in the file at the following path:\n" +
                                           Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\result-date.txt");
                        break;
                    case 3:
                        fileProcessingServise = new FileProcessingService();
                        fileProcessingServise.FileProcessing();
                        Console.WriteLine("\nYou can see the result in the file at the following path:\n" +
                                           Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\result-date.txt");
                        break;
                }

                break;
            }

            Console.WriteLine("Press any key to close the app...");
            Console.ReadKey();
        }
    }
}