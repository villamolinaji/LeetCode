#pragma warning disable S125 // Sections of code should not be commented out
//var outptut = _405.Solution01.GetEncryptedString("aaa", 1);

//var outptut = _405.Solution02.ValidStrings(3);

//char[][] grid = new char[][] {
//	new char[] { 'X', 'Y', '.' },
//	new char[] { 'Y', '.', '.' }
//};	
//char[][] grid = new char[][] {
//	new char[] { '.', '.' },
//	new char[] { 'Y', 'X' }
//};
//var outptut = _405.Solution03.NumberOfSubmatrices(grid);

var solution = new _405.Solution04();
var outptut = solution.MinimumCost("abcdef", ["abdef", "abc", "d", "def", "ef"], [100, 1, 1, 10, 5]);

Console.WriteLine(outptut);
#pragma warning restore S125 // Sections of code should not be commented out