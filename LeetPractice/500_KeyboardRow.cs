using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPractice
{
    public class _500_KeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            List<string> wordList = new List<string>();
            string[] resultArray = [];
            int matchCount1 = 0; int matchCount2 = 0; int matchCount3 = 0;
            char[] firstRow = ['A', 'a', 'S', 's', 'D', 'd', 'F', 'f', 'G', 'g', 'H', 'h','J', 'j', 'K', 'k', 'L', 'l'];
            char[] secondRow = ['Q', 'q', 'W', 'w', 'E', 'e', 'R', 'r', 'T', 't', 'Y', 'y', 'U', 'u', 'I', 'i', 'O', 'o', 'P', 'p'];
            char[] thirdRow = ['Z', 'z', 'X', 'x', 'C', 'c', 'V', 'v', 'B', 'b', 'N', 'n', 'M', 'm'];

            if (words.Length > 0)
            {
                foreach (var item in words)
                {
                    string _currentWord = item;

                    matchCount1 = 0; matchCount2 = 0; matchCount3 = 0;
                    foreach (Char word in _currentWord)
                    {
                        if (firstRow.Contains(word))
                        {
                            matchCount1++;
                        }

                        if (secondRow.Contains(word))
                        {
                            matchCount2++;
                        }

                        if (thirdRow.Contains(word))
                        {
                            matchCount3++;
                        }

                        if ((matchCount1 == _currentWord.Length) || (matchCount2 == _currentWord.Length) || (matchCount3 == _currentWord.Length))
                        {
                            wordList.Add(_currentWord);
                            resultArray = wordList.ToArray();
                        }

                    }

                }

            }

            return resultArray;
        }
    }
}
