using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ApplicationBusinessLayer
{
    public class BusinessLogic
    {
        /// <summary>
        /// Returns distinct words with number count in input sentence. Does't count punctuations.
        /// </summary>
        /// <param name="Sentence">Input String Sentence</param>
        /// <returns></returns>
        public string GetDistinctWordInASentence(string Sentence)
        {
            string Output = string.Empty;
            Sentence = Sentence.ToLower();
            if (!string.IsNullOrWhiteSpace(Sentence))
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 ]");
                Sentence = rgx.Replace(Sentence, "");
                string[] lstWords = Sentence.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var lstItems = lstWords.GroupBy(x => x).Select(x => new { Word = x.Key, RepeatNumber = x.Count() }).ToList();
                foreach (var item in lstItems)
                {
                    Output += item.Word + "-" + item.RepeatNumber + "\n";
                }
                Output = Output.TrimEnd('\n');
            }
            return Output;
        }
    }
}
