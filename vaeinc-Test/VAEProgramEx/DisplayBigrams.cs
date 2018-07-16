using System;
using System.Collections.Generic;
using System.Linq;

namespace VAEProgramEx
{
    /// <summary>
    /// Class DisplayBigrams.
    /// Used for diplaying bigrams - histograms in console
    /// </summary>
    public class DisplayBigrams
    {
        /// <summary>
        /// Gets the bigrams to display.
        /// </summary>
        /// <param name="resultToShow">The result to show.</param>
        /// <param name="openWith">The open with.</param>
        public static void GetBigramsToDisplay(List<LineProcessor.BigramTuple<string, string, int>> resultToShow, List<LineProcessor.BigramTuple<string, string, int>> openWith)
        {
            foreach (LineProcessor.BigramTuple<string, string, int> wordPair in resultToShow.Distinct())
            {
                int bgCount = openWith.Count(t => t.Equals(wordPair));
                wordPair.BigramCount = bgCount;

                // Avoiding odd number values from displaying the last word only...
                if (!string.IsNullOrEmpty(wordPair.Word2))
                    Console.WriteLine("{0}, {1}, {2}", wordPair.Word1, wordPair.Word2,
                        wordPair.BigramCount);
            }
        }
    }
}