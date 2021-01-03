using System;
using System.Collections.Generic;
using System.Text;

namespace Variables2
{
    public class StringUtility
    {
        public static string SummerizeText(string sentence, int maxLenghth = 26)
        {
            if (sentence.Length < maxLenghth)
                return sentence;

            var words = sentence.Split(' ');     //use whitespace to separate the sentence;
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChar += word.Length + 1; //+1 because of the space after the word
                if (totalChar > maxLenghth)
                    break;
            }

            var summary = String.Join(" ", summaryWords) + "...";
            return summary;

        }

    }
}
