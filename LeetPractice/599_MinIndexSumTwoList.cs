using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPractice
{
    public class _599_MinIndexSumTwoList
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> wordList = new List<string>();
            string[] resultArray = [];
            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
           

            foreach (var item in list1)
            {
                string _currentValue = item.ToString();
                if (list2.Contains(_currentValue))
                {
                    int list1_index = Array.IndexOf(list1, _currentValue);
                    int list2_index = Array.IndexOf(list2, _currentValue);
                    int sumOfIndex = list1_index + list2_index;

                    //objDictionary.Add(sumOfIndex, _currentValue);
                }
            }

            return resultArray;
        }
    }
}
