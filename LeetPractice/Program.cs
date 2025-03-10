
using LeetPractice;

#region [Problem: 2011]

//_2011_Perform_Operation SS = new _2011_Perform_Operation();
//int value = SS.FinalValueAfterOperations(["--X", "X++", "X++"]); // case 1: ["--X","X++","X++"]
//int value = SS.FinalValueAfterOperations(["++X", "++X", "X++"]); // case 2: ["++X", "++X", "X++"]
//int value = SS.FinalValueAfterOperations(["X++", "++X", "--X", "X--"]);   // case 3: ["X++","++X","--X","X--"]
//Console.WriteLine(value);

#endregion


#region [Problem: 500]

//_500_KeyboardRow keyboardRow = new _500_KeyboardRow();

//string[] value = keyboardRow.FindWords(["Hello", "Alaska", "Dad", "Peace"]); // test case1: ["Hello", "Alaska", "Dad", "Peace"]  

//string[] value = keyboardRow.FindWords(["omk"]); // test case2: ["omk"] 

//string[] value = keyboardRow.FindWords(["adsdf", "sfd"]); // test case3: ["adsdf","sfd"]

//string[] value = keyboardRow.FindWords(["qaz", "wsx", "edc", "rfv", "tgb", "yhn", "ujm", "ik", "pklo", "ppppppp"]);


//foreach (string item in value)
//{
//    Console.WriteLine(item);
//}

#endregion



#region [Problem: 599]

//599. Minimum Index Sum of Two Lists

//_599_MinIndexSumTwoList objMinIndex = new _599_MinIndexSumTwoList();

//string[] list1 = ["Shogun", "Tapioca Express", "Burger King", "KFC"];
//string[] list2 = ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"];


string[] list1 = ["happy", "sad", "good"];
string[] list2 = ["sad", "happy", "good"];



//string[] value = objMinIndex.FindRestaurant(list1, list2);

//foreach (string item in value)
//{
//    Console.WriteLine(item);
//}

#endregion

#region [Problem: 748]

//748. Shortest Completing Word

_748_ShortestCompletingWord objShortWord = new _748_ShortestCompletingWord();

string licensePlate = "1s3 PSt";
string[] words = ["step", "steps", "stripe", "stepple"];

string shortestWord = objShortWord.ShortestCompletingWord(licensePlate, words);

Console.WriteLine(shortestWord);


#endregion