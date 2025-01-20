using System;

class LogicalOperators {
	static void Main(string[] args) {	
		bool x = true;
		bool y = false;

		Console.WriteLine("x && y: " + (x && y)); // false
		Console.WriteLine("x || y: " + (x || y)); // true
		Console.WriteLine("!x: " + (!x)); // false
		Console.WriteLine("!y: " + (!y)); // true
	}
}
