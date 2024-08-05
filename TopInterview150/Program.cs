using TopInterview150;

var solution = new Solution033();

#pragma warning disable S125 // Sections of code should not be commented out

//solution.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
//var output = solution.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
//var output = solution.RemoveDuplicates([1, 1, 1, 2, 2, 3]);
//var output = solution.MajorityElement([3, 2, 3]);
//solution.Rotate([1, 2], 3);
//var output = solution.MaxProfit([7, 1, 5, 3, 6, 4]);
//var output = solution.MaxProfit([7, 1, 5, 3, 6, 4]);
//var output = solution.CanJump([0]);
//var output = solution.Jump([2, 3, 1, 1, 4]);
//var output = solution.HIndex([3, 0, 6, 1, 5]);
//var output = solution.CanCompleteCircuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]);
//var output = solution.Candy([1, 0, 2]);
//var output = solution.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]);
//var output = solution.RomanToInt("III");
//var output = solution.IntToRoman(3749);
//var output = solution.LengthOfLastWord("Hello World");
//var output = solution.LongestCommonPrefix(["reflower", "flow", "flight"]);
//var output = solution.Convert("AB", 1);
//var output = solution.StrStr("sadbutsad", "sad");
//var output = solution.FullJustify(["What", "must", "be", "acknowledgment", "shall", "be"], 16);
//var output = solution.IsPalindrome("A man, a plan, a canal: Panama");
//var output = solution.TwoSum([-1, -1, 1, 1, 1, 1], -2);
//var output = solution.ThreeSum([-1, 0, 1, 2, -1, -4]);
//var output = solution.MinSubArrayLen(213, [12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12]);
//var output = solution.LengthOfLongestSubstring("abcabcbb");
//var output = solution.FindSubstring("barfoothefoobarman", ["foo", "bar"]);
var output = solution.MinWindow("ADOBECODEBANC", "ABC");

#pragma warning restore S125 // Sections of code should not be commented out

Console.WriteLine(output);