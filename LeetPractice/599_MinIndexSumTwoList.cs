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
            Dictionary<int, List<string>> objDictionary = new Dictionary<int, List<string>>();
            int minIndexSum = int.MaxValue;

            foreach (var item in list1)
            {
                string _currentValue = item.ToString();
                if (list2.Contains(_currentValue))
                {
                    int list1_index = Array.IndexOf(list1, _currentValue);
                    int list2_index = Array.IndexOf(list2, _currentValue);
                    int sumOfIndex = list1_index + list2_index;

                    // Add to dictionary
                    if (!objDictionary.ContainsKey(sumOfIndex))
                    {
                        objDictionary[sumOfIndex] = new List<string>();
                    }
                    objDictionary[sumOfIndex].Add(item);

                    // Keep track of the minimum sum index
                    minIndexSum = Math.Min(minIndexSum, sumOfIndex);
                }
            }

            return objDictionary[minIndexSum].ToArray();
        }
    }
}
