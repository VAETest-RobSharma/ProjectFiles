using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;
using VAEProgramEx.LineProcessor;

namespace VAEProgramEx
{

    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <remarks>Test Project by Prabodh (Rob) Sharma
        ///            Date: 7/13/2018
        ///  </remarks>
        /// <param name="args">The arguments.</param>
        /// <exception cref="IOException">An I/O error occurred.</exception>
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter location and file name to generate bigrams/histogtrams: ");
            string inputFile = Console.ReadLine();

            try
            {

                if (inputFile != null)
                {
                    string[] lines = ReadAllLines(inputFile);
                    List<LineProcessor.BigramTuple<String, String, int>> openWith =
                        new List<LineProcessor.BigramTuple<string, string, int>>();

                    foreach (var line in lines)
                    {
                        var wordList = ParseLineToWords.SetupWordsFromLine(line);
                        PopulateTuples.PopulateTuplesFromLine(wordList, openWith);

                        Console.WriteLine();
                        var resultToShow = openWith.ToList();
                        DisplayBigrams.GetBigramsToDisplay(resultToShow, openWith);
                        Console.WriteLine("Press any key to return");
                        Console.ReadKey();
                    }
                }
            }

            catch (FileNotFoundException ex)
            {
                Console.Write("File not found! - " + ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.Write("Could not load file to process! - " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.Write("An error occurred while processing the file" + ex.Message);
            }
        }
    }
    
}
