using System;

class RelationalOperators {
	static void Main(string[] args) {
		int a = 10;
		int b = 5;

		Console.WriteLine("a == b: " + (a == b)); // false
		Console.WriteLine("a != b: " + (a != b)); // true
		Console.WriteLine("a > b: " + (a > b)); // true
		Console.WriteLine("a < b: " + (a < b)); // false
		Console.WriteLine("a >= b: " + (a >= b)); // true
		Console.WriteLine("a <= b: " + (a <= b)); // false
	}
}
