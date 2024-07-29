using DailyChallenge;

var solution = new Solution002();

#pragma warning disable S125 // Sections of code should not be commented out
//var outptut = solution.FindTheCity(4, [[0, 1, 3], [1, 2, 1], [1, 3, 4], [2, 3, 1]], 4);
var outptut = solution.NumTeams([2, 5, 3, 4, 1]);
#pragma warning restore S125 // Sections of code should not be commented out

Console.WriteLine(outptut);
