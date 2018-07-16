using System.Collections.Generic;

namespace VAEProgramEx.LineProcessor
{
    public class PopulateTuples
    {
        /// <summary>
        /// Populates the tuples from line.
        /// </summary>
        /// <param name="wordList">The word list.</param>
        /// <param name="openWith">The open with.</param>
        public static void PopulateTuplesFromLine(string[] wordList, List<LineProcessor.BigramTuple<string, string, int>> openWith)
        {
            for (int i = 0; i < wordList.Length - 1; i++)
            {
                openWith.Add(
                    new LineProcessor.BigramTuple<string, string, int>(wordList[i], wordList[i + 1], 0));
            }
        }
    }
}