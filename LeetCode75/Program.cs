﻿#pragma warning disable S125 // Sections of code should not be commented out
using LeetCode75;

var solution = new Solution35();

//var outptut = solution.MergeAlternately("abcd", "pq");
//var outptut = solution.GcdOfStrings("LEET", "CODE");
//var outptut = solution.KidsWithCandies([12,1,12], 10);
//var outptut = solution.CanPlaceFlowers([0, 0, 0, 0, 1], 2);
//var outptut = solution.ReverseVowels("leetcode");
//var outptut = solution.ReverseWords("a good   example");
//var outptut = solution.ProductExceptSelf([-1, 1, 0, -3, 3]);
//var outptut = solution.IncreasingTriplet([0, 4, 2, 1, 0, -1, -3]);
//var outptut = solution.Compress(['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b','c','c']);
//solution.MoveZeroes([1,0,0]);
//var outptut = solution.IsSubsequence("abc", "ahbgdc");
//var outptut = solution.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
//var outptut = solution.MaxOperations([4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4], 2);
//var outptut = solution.FindMaxAverage([1, 12, -5, -6, 50, 3], 4);
//var outptut = solution.MaxVowels("weallloveyou", 7);
//var outptut = solution.LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2);
//var outptut = solution.LongestSubarray([1, 1, 0, 1]);
//var outptut = solution.LargestAltitude([-5, 1, 5, 0, -7]);
//var outptut = solution.PivotIndex([1, 7, 3, 6, 5, 6]);
//var outptut = solution.FindDifference([1, 2, 3], [2, 4, 6]);
//var outptut = solution.UniqueOccurrences([1, 2, 2, 1, 1, 3]);
//var outptut = solution.CloseStrings("cabbba", "abbccc");
//var outptut = Solution23.EqualPairs([[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]]);
//var outptut = solution.RemoveStars("v*u*q*txwx**v***hs*cl*c***ci**n*e*t*z*c*sjae****z*ux*ka*z*z*c*fv**g**w*k");
//var outptut = solution.AsteroidCollision([1, -2, 2, -1]);
//var outptut = solution.DecodeString("3[a2[c]]");
//var outptut = solution.PredictPartyVictory("DDDRRRRR");
//var listNode1 = new ListNode(5);
//var listNode2 = new ListNode(4);
//var listNode3 = new ListNode(2);
//var listNode4 = new ListNode(1);
//listNode1.next = listNode2;
//listNode2.next = listNode3;
//listNode3.next = listNode4;
//var outptut = solution.DeleteMiddle(listNode1);
//var outptut = solution.ReverseList(listNode1);
//var outptut = solution.PairSum(listNode1);
var treeNode1 = new TreeNode(3);
var treeNode2 = new TreeNode(1);
var treeNode3 = new TreeNode(4);
var treeNode4 = new TreeNode(3);
var treeNode5 = new TreeNode(1);
var treeNode6 = new TreeNode(5);
treeNode1.left = treeNode2;
treeNode1.right = treeNode3;
treeNode2.left = treeNode4;
treeNode3.left = treeNode5;
treeNode3.right = treeNode6;
//var outptut = solution.MaxDepth(treeNode1);
//var outptut = solution.LeafSimilar(treeNode1, treeNodeb1);
var outptut = solution.GoodNodes(treeNode1);

Console.WriteLine(outptut);
#pragma warning restore S125 // Sections of code should not be commented out