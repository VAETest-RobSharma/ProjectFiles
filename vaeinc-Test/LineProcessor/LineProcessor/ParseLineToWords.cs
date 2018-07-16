using System.Linq;

namespace VAEProgramEx.LineProcessor
{
    public class ParseLineToWords
    {
        /// <summary>
        /// Setups the words from line.
        /// </summary>
        /// <param name="line">The line.</param>
        /// <returns>System.String[].</returns>
        public static string[] SetupWordsFromLine(string line)
        {
            string[] wordList = line.Split(' ');
            // Loop over all over the words in our wordList...
            foreach (string word in wordList)
            {
                if (wordList.Length % 2 != 0)
                {
                    string[] addEven = {""};
                    wordList = wordList.Concat(addEven).ToArray();
                }
            }
            return wordList;
        }
    }
}