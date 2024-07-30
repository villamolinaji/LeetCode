using TopInterview150;

var solution = new Solution010();

#pragma warning disable S125 // Sections of code should not be commented out

//solution.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
//var output = solution.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
//var output = solution.RemoveDuplicates([1, 1, 1, 2, 2, 3]);
//var output = solution.MajorityElement([3, 2, 3]);
//solution.Rotate([1, 2], 3);
//var output = solution.MaxProfit([7, 1, 5, 3, 6, 4]);
//var output = solution.MaxProfit([7, 1, 5, 3, 6, 4]);
//var output = solution.CanJump([0]);
var output = solution.Jump([2, 3, 1, 1, 4]);

#pragma warning restore S125 // Sections of code should not be commented out

Console.WriteLine(output);