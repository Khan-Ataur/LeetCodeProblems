using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetPractice
{
    public class _748_ShortestCompletingWord
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            string _finalShortestWord = "";

            licensePlate = licensePlate.Trim().ToLower();
            licensePlate = Regex.Replace(licensePlate, "[0-9 ]", ""); // spts

            var charCount = licensePlate.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            int totalChar = charCount.Count();

            var targetFreq = licensePlate.ToLower().Where(char.IsLetter)
      .GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

             _finalShortestWord = words.Where(word => targetFreq.All(kvp => word.Count(c => c == kvp.Key) >= kvp.Value))
                       .OrderBy(word => word.Length)
                       .First();

            return _finalShortestWord;

        }


    }
}
