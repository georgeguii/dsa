using study_dsa;

#region Reverse Words

// string input1 = "Let's take LeetCode contest";
// string result1 = ReverseWords.Handler(input1);
// Console.WriteLine(result1); // Output: "s'teL ekat edoCteeL tsetnoc"

#endregion

#region Binary Search
// int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
// int[] numbers2 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 };
// int[] numbers3 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39,
//     41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79 };
// int[] numbers4 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39,
//     41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79,
//     81, 83, 85, 87, 89, 91, 93, 95, 97, 99, 101, 103, 105, 107, 109, 111, 113, 115, 117, 119,
//     121, 123, 125, 127, 129, 131, 133, 135, 137, 139, 141, 143, 145, 147, 149, 151, 153, 155, 157, 159 };
//
// int target = 53;
//
// var result = BinarySearch.Handler(numbers4, target);
// Console.WriteLine(result);
//
// if (result != -1)
//     Console.WriteLine($"Valor {target} encontrado na posição {result}.");
// else
//     Console.WriteLine($"Valor {target} não encontrado no array.");
#endregion

#region SlidingWindow
string input1 = "bcbbbcba";
var result = SlidingWindow.Handler(input1);
Console.WriteLine(result); // Output: "s'teL ekat edoCteeL tsetnoc"

#endregion