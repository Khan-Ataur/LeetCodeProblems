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

            Dictionary<char,int> keyValues = new Dictionary<char,int>();
            foreach (var word in words) 
            {
                foreach (char item in word)
                {
                    char X = item;
                }
            }




            foreach (var item in words)
            {
                var word_charCount = item.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

                

            }

            return _finalShortestWord;
        }


    }
}
